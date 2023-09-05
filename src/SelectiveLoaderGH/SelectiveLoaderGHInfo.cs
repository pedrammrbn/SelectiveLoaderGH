using Grasshopper;
using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace SelectiveLoaderGH
{
    public class SelectiveLoaderGHInfo : GH_AssemblyInfo
    {
        public override string Name => "SelectiveLoaderGH";

        //Return a 24x24 pixel bitmap to represent this GHA library.
        public override Bitmap Icon => null;

        //Return a short string describing the purpose of this GHA library.
        public override string Description => "";

        public override Guid Id => new Guid("ff8c19a4-806b-40f6-9b54-3155cf5bcceb");

        //Return a string identifying you or your company.
        public override string AuthorName => "";

        //Return a string representing your preferred contact details.
        public override string AuthorContact => "";
    }
}