using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CP_v1
{
    /// <summary>
    /// клас, що вміщує дані робочої області
    /// </summary>
    public partial class fundamentWorkspace
    {
        public string Iterator(int count)
        {
            string s;
            switch (count)
            {
                case 0: { s = NumberOfStairs; break; };
                case 1: { s = SizePerMeter; break; };
                case 2: { s = Convert.ToString(FundamentType); break; };
                case 3: { s = WallHeight; break; };
                case 4: { s = Convert.ToString(TypeOfWall); break; };
                case 5: { s = DeepLeftCorner; break; };
                case 6: { s = DeepRightCorner; break; };
                case 7: { s = WidthLeftCorner; break; };
                case 8: { s = WidthRightCorner; break; };
                default: { s = "SAVE ERROR"; break; };
            }
            if (s == "" || s == null)
                s = "NULL";
            return s;
        }
        public void Seterator(int count, string value)
        {
            if (value == "NULL")
                value = " ";
            switch (count)
            {
                case 0: { NumberOfStairs=value; break; };
                case 1: { SizePerMeter = value; break; };
                case 2: { FundamentType=Convert.ToInt32(value); break; };
                case 3: { WallHeight = value; break; };
                case 4: { TypeOfWall=Convert.ToInt32(value); break; };
                case 5: { DeepLeftCorner = value; break; };
                case 6: { DeepRightCorner = value; break; };
                case 7: { WidthLeftCorner = value; break; };
                case 8: { WidthRightCorner = value; break; };
                default: { break; };
            }
        }
        /// <summary>
        /// save current parameters
        /// </summary>
        /// <param name="nos"></param>
        /// <param name="spm"></param>
        /// <param name="ft"></param>
        /// <param name="wh"></param>
        /// <param name="tow"></param>
        /// <param name="dlc"></param>
        /// <param name="drc"></param>
        /// <param name="wlc"></param>
        /// <param name="wrc"></param>
        public void Save(string nos, string spm, int ft, string wh, int tow,
            string dlc, string drc, string wlc, string wrc)
        {
            numberOfStairs = nos;
            sizePerMeter = spm;
            fundamentType = ft;
            wallHeight = wh;
            typeOfWall = tow;
            deepLeftCorner = dlc;
            deepRightCorner = drc;
            widthLeftCorner = wlc;
            widthRightCorner = wrc;
        }
        public fundamentWorkspace()
        {
            fundamentType = new int();
            typeOfWall = new int();
            fundamentType = 0;
            typeOfWall = 0;
        }

        #region parameters
        public const int count=9;
        private string numberOfStairs;
        private string sizePerMeter;
        private int fundamentType;
        private string wallHeight;
        private int typeOfWall;
        private string deepLeftCorner;
        private string deepRightCorner;
        private string widthLeftCorner;
        private string widthRightCorner;

        public string DeepLeftCorner
        {
            get { return deepLeftCorner; }
            set { deepLeftCorner = value; }
        }
        public string DeepRightCorner
        {
            get { return deepRightCorner; }
            set { deepRightCorner = value; }
        }
        public string WidthLeftCorner
        {
            get { return widthLeftCorner; }
            set { widthLeftCorner = value; }
        }
        public string WidthRightCorner
        {
            get { return widthRightCorner; }
            set { widthRightCorner = value; }
        }
        public string SizePerMeter
        {
            get { return sizePerMeter; }
            set { sizePerMeter = value; }
        }
        public string NumberOfStairs
        {
            get { return numberOfStairs; }
            set { numberOfStairs = value; }
        }
        public int FundamentType
        {
            get { return fundamentType; }
            set { fundamentType = value; }
        }
        public string WallHeight
        {
            get { return wallHeight; }
            set { wallHeight = value; }
        }
        public int TypeOfWall
        {
            get { return typeOfWall; }
            set { typeOfWall = value; }
        }
        #endregion

    }
}
