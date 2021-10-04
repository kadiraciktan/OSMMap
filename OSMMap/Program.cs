using NetTopologySuite.Features;
using NetTopologySuite.Geometries;
using NetTopologySuite.IO;
using OsmSharp;
using OsmSharp.Streams;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
namespace OSMMap
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var fileStream = new FileInfo(@"turkey-latest.osm.pbf").OpenRead())
            {


            }
        }
    }
}
