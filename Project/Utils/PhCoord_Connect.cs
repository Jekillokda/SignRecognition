using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Utils
{
    static class PhCoord_Connect
    {
        public static IEnumerable<PhotoData> Connect(ImageFolder f, List<MovementPoint> pointsList, int timeStepMilliseconds)
        {
            var pointsDates = pointsList.Select(p => p.Date);
            var firstPhotoDate = pointsDates.Min();
            var lastPhotoDate = pointsDates.Max();

            List<Photo> photos = new List<Photo>();
            for (int i = 0; i < f.GetCount(); i++)
            {
                photos.Add(new Photo { Number = i, FileName = f.GetImg(i) });
            }

            return photos.Select(photo =>
            {
                var photoDateTime = firstPhotoDate.AddMilliseconds(photo.Number * timeStepMilliseconds);

                var maxTimeRangeDiff = timeStepMilliseconds / 2;

                var closestPointInRange = pointsList
                    .Where(point => Math.Abs((point.Date - photoDateTime).TotalMilliseconds) < maxTimeRangeDiff)
                    .OrderBy(point => Math.Abs((point.Date - photoDateTime).TotalMilliseconds))
                    .FirstOrDefault();

                if (closestPointInRange == null)
                {
                    return null;
                }

                return new PhotoData
                {
                    MovementPoint = closestPointInRange,
                    Photo = photo
                };


            })
            .Where(pd => pd != null);
        }
    }
}   
