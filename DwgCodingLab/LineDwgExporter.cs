using ACadSharp;
using ACadSharp.Entities;
using ACadSharp.IO;
using CSMath;

namespace DwgCodingLab;

internal static class LineDwgExporter
{
    public static void Export(string filePath)
    {
        var document = new CadDocument(ACadVersion.AC1027);
        var start = new XYZ(0, 0, 0);
        var end = new XYZ(100, 0, 0);

        var line = new Line(start, end);
        document.Entities.Add(line);
        DwgWriter.Write(filePath, document);
    }
}