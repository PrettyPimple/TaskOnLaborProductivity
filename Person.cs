using System;


namespace TestImageFactory
{
    class Person//Person class description
    {
        private uint? numImg = 0;
        public uint? NumImg
        {
            get { return numImg; }
            set { numImg = value; }
        }
        private uint? time = 0;
        public uint? Time
        {
            get { return time; }
            set { time = value; }
        }
        private float? divisionRes = 0.0f;
        public float? DivisionRes
        {
            get { return divisionRes; }
            set { divisionRes = value; }
        }
        private float? totalNumOfImg;
        public float? TotalNumOfImg
        {
            get { return totalNumOfImg; }
            set { totalNumOfImg = value; }
        }

        public Person(uint? numImgC, uint? timeC)
        {
            this.numImg = numImgC;
            this.time = timeC;
            this.divisionRes = (float?)numImgC / (float?)timeC;

        }

        internal uint? SeparateCalc(float? totalTimeCalc)//Method that calculate Integer number of edited images 
        {                                                //by this person
            this.TotalNumOfImg = totalTimeCalc / this.Time * this.NumImg;
            return (uint?)Math.Round((double)this.totalNumOfImg, 0, MidpointRounding.AwayFromZero);
        }
        internal float? AccuracySeparateCalc(float? totalTimeCalc)//Method that calculate number 
        {                                                         //of edited images by this person
            this.TotalNumOfImg = totalTimeCalc / this.Time * this.NumImg;
            return this.TotalNumOfImg;
        }
    }
}
