using Potrcko.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pottrcko.Models
{
    public class ClosedAd
    {
        public int ID { get; set; }
        public Ad Ad { get; set; }

        public string OpinionForOwner { get; set; }

        public string OpinionForClient { get; set; }

        public float GradeForClient { get; set; }

        public float GradeForOwner { get; set; }

    }
}