// -----------------------------------------------------------------------
// <copyright file="Wall.cs" company="">
// TODO: Update copyright text.
// </copyright>
// -----------------------------------------------------------------------

namespace prep.CodeKata
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    /// <summary>
    /// TODO: Update summary.
    /// </summary>
    public class Wall
    {
        public int K { get; set; }
        public int N { get; set; }

        public int Height
        {
            get { return K; }
        }

        public int Width
        {
            get { return Convert.ToInt32(Math.Pow(2, N)); }
        }
    }
}
