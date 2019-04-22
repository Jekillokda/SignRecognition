using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class CNN
    {
       
        CNN()
        {
            var dataFolder = "Data";//files must be on the same folder as program
            var dataPath = Path.Combine(dataFolder, "train_cntk.txt");
            var trainPath = Path.Combine(dataFolder, "test_cntk.txt");
            //Network definition
            int inputDim = 4;
            int numOutputClasses = 3;//Sign Classes count
            int numHiddenLayers = 1;//Count of Hidden Layers
            int hidenLayerDim = 6;
            uint sampleSize = 130;
        }
    public void Classify()
        {
            
        }
        public void Learn()
        {

        }
        //
        /*public static void TrainIrisByMinibatchSource(DeviceDescriptor device)
        {
            var dataFolder = "Data";//files must be on the same folder as program
            var dataPath = Path.Combine(dataFolder, "trainIris_cntk.txt");
            var trainPath = Path.Combine(dataFolder, "testIris_cntk.txt");

            var featureStreamName = "features";
            var labelsStreamName = "label";

            //Network definition
            int inputDim = 4;
            int numOutputClasses = 3;
            int numHiddenLayers = 1;
            int hidenLayerDim = 6;
            uint sampleSize = 130;

            //stream configuration to distinct features and labels in the file
            var streamConfig = new StreamConfiguration[]
               {
                   new StreamConfiguration(featureStreamName, inputDim),
                   new StreamConfiguration(labelsStreamName, numOutputClasses)
               };


            // build a NN model
            //define input and output variable and connecting to the stream configuration
            var feature = Variable.InputVariable(new NDShape(1, inputDim), DataType.Float, featureStreamName);
            var label = Variable.InputVariable(new NDShape(1, numOutputClasses), DataType.Float, labelsStreamName);


            //Build simple Feed Froward Neural Network model
            // var ffnn_model = CreateMLPClassifier(device, numOutputClasses, hidenLayerDim, feature, classifierName);
            var ffnn_model = createFFNN(feature, numHiddenLayers, hidenLayerDim, numOutputClasses, Activation.Tanh, "IrisNNModel", device);

            //Loss and error functions definition
            var trainingLoss = CNTKLib.CrossEntropyWithSoftmax(new Variable(ffnn_model), label, "lossFunction");
            var classError = CNTKLib.ClassificationError(new Variable(ffnn_model), label, "classificationError");


            // prepare the training data
            var minibatchSource = MinibatchSource.TextFormatMinibatchSource(
                dataPath, streamConfig, MinibatchSource.InfinitelyRepeat, true);
            var featureStreamInfo = minibatchSource.StreamInfo(featureStreamName);
            var labelStreamInfo = minibatchSource.StreamInfo(labelsStreamName);

            // set learning rate for the network
            var learningRatePerSample = new TrainingParameterScheduleDouble(0.001125, 1);

            //define learners for the NN model
            var ll = Learner.SGDLearner(ffnn_model.Parameters(), learningRatePerSample);

            //define trainer based on ffnn_model, loss and error functions , and SGD learner 
            var trainer = Trainer.CreateTrainer(ffnn_model, trainingLoss, classError, new Learner[] { ll });

            //Preparation for the iterative learning process
            //used 800 epochs/iterations. Batch size will be the same as sample size since the data set is small
            int epochs = 800;
            int i = 0;
            while (epochs > -1)
            {
                var minibatchData = minibatchSource.GetNextMinibatch(sampleSize, device);
                //pass to the trainer the current batch separated by the features and label.
                var arguments = new Dictionary<Variable, MinibatchData>
                {
                    { feature, minibatchData[featureStreamInfo] },
                    { label, minibatchData[labelStreamInfo] }
                };

                trainer.TrainMinibatch(arguments, device);


                printTrainingProgress(trainer, i++, 50);

                // MinibatchSource is created with MinibatchSource.InfinitelyRepeat.
                // Batching will not end. Each time minibatchSource completes an sweep (epoch),
                // the last minibatch data will be marked as end of a sweep. We use this flag
                // to count number of epochs.
                if (minibatchData.Values.Any(a => a.sweepEnd))
                {
                    epochs--;
                }
            }
            //Summary of training
            double acc = Math.Round((1.0 - trainer.PreviousMinibatchEvaluationAverage()) * 100, 2);
            Console.WriteLine($"------TRAINING SUMMARY--------");
            Console.WriteLine($"The model trained with the accuracy {acc}%");

            //// validate the model
            // this will be posted as separate blog post
        }


        private static Function createFFNN(Variable input, int hiddenLayerCount, int hiddenDim, int outputDim, Activation activation, string modelName, DeviceDescriptor device)
        {
            //First the parameters initialization must be performed
            var glorotInit = CNTKLib.GlorotUniformInitializer(
                    CNTKLib.DefaultParamInitScale,
                    CNTKLib.SentinelValueForInferParamInitRank,
                    CNTKLib.SentinelValueForInferParamInitRank, 1);

            //hidden layers creation
            //first hidden layer
            Function h = simpleLayer(input, hiddenDim, device);
            h = applyActivationFunction(h, activation);
            for (int i = 1; i < hiddenLayerCount; i++)
            {
                h = simpleLayer(h, hiddenDim, device);
                h = applyActivationFunction(h, activation);
            }
            //the last action is creation of the output layer
            var r = simpleLayer(h, outputDim, device);
            r.SetName(modelName);
            return r;
        }

        private static Function applyActivationFunction(Function layer, Activation actFun)
        {
            switch (actFun)
            {
                default:
                case Activation.None:
                    return layer;
                case Activation.ReLU:
                    return CNTKLib.ReLU(layer);
                case Activation.Sigmoid:
                    return CNTKLib.Sigmoid(layer);
                case Activation.Tanh:
                    return CNTKLib.Tanh(layer);
            }
        }
        private static Function simpleLayer(Function input, int outputDim, DeviceDescriptor device)
        {
            //prepare default parameters values
            var glorotInit = CNTKLib.GlorotUniformInitializer(
                    CNTKLib.DefaultParamInitScale,
                    CNTKLib.SentinelValueForInferParamInitRank,
                    CNTKLib.SentinelValueForInferParamInitRank, 1);

            //
            var var = (Variable)input;
            var shape = new int[] { outputDim, var.Shape[0] };
            var weightParam = new Parameter(shape, DataType.Float, glorotInit, device, "w");
            var biasParam = new Parameter(new NDShape(1, outputDim), 0, device, "b");


            return CNTKLib.Times(weightParam, input) + biasParam;

        }

        private static void printTrainingProgress(Trainer trainer, int minibatchIdx, int outputFrequencyInMinibatches)
        {
            if ((minibatchIdx % outputFrequencyInMinibatches) == 0 && trainer.PreviousMinibatchSampleCount() != 0)
            {
                float trainLossValue = (float)trainer.PreviousMinibatchLossAverage();
                float evaluationValue = (float)trainer.PreviousMinibatchEvaluationAverage();
                Console.WriteLine($"Minibatch: {minibatchIdx} CrossEntropyLoss = {trainLossValue}, EvaluationCriterion = {evaluationValue}");
            }
        }*/
        //
    }
}