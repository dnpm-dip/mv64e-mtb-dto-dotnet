using System.Diagnostics;
using System.Reflection;

namespace MV64e.MTB.Test;

public class MtbTest
{
    [Test]
    public void ShouldParseJsonData()
    {
        var assembly = Assembly.GetExecutingAssembly();
        const string resourceName = @"MV64e.MTB.Test.TestData.mv64e-mtb-fake-patient.json";

        using var stream = assembly.GetManifestResourceStream(resourceName);
        Debug.Assert(stream != null, "Cannot find test data file");
        using var reader = new StreamReader(stream);
        
        var json = reader.ReadToEnd();
        var mtb = Mtb.FromJson(json);
                
        Assert.IsNotNull(mtb);
    }
    
    [Test]
    public void ShouldKeepTimezone()
    {
        var assembly = Assembly.GetExecutingAssembly();
        const string resourceName = @"MV64e.MTB.Test.TestData.mv64e-mtb-fake-patient.json";

        using var stream = assembly.GetManifestResourceStream(resourceName);
        Debug.Assert(stream != null, "Cannot find test data file");
        using var reader = new StreamReader(stream);
        
        var json = reader.ReadToEnd();
        var mtb = Mtb.FromJson(json);

        var actual = Serialize.ToJson(mtb);
        Assert.That(actual, Does.Contain("\"birthDate\":\"1985-05-19\""));
    }
}