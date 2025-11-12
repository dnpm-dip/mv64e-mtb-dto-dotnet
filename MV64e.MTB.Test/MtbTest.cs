using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;

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
    public void ShouldKeepPatientBirthdateFormatInYearMonth()
    {
        var assembly = Assembly.GetExecutingAssembly();
        const string resourceName = @"MV64e.MTB.Test.TestData.mv64e-mtb-fake-patient.json";

        using var stream = assembly.GetManifestResourceStream(resourceName);
        Debug.Assert(stream != null, "Cannot find test data file");
        using var reader = new StreamReader(stream);
        
        var json = reader.ReadToEnd();
        
        // Fake birthdate in old format
        var regex = new Regex(@"""birthDate"":""\d{4}-\d{2}(-\d{2})?""");
        json = regex.Replace(json, @"""birthDate"":""2025-03""");
        Assert.That(json, Does.Contain(@"""birthDate"":""2025-03"""));

        var mtb = Mtb.FromJson(json);
        var actual = Serialize.ToJson(mtb);
        // Expect new format
        Assert.That(actual, Does.Contain(@"""birthDate"":""2025-03"""));
    }
    
    [Test]
    public void ShouldConvertPatientBirthdateFormatToYearMonth()
    {
        var assembly = Assembly.GetExecutingAssembly();
        const string resourceName = @"MV64e.MTB.Test.TestData.mv64e-mtb-fake-patient.json";

        using var stream = assembly.GetManifestResourceStream(resourceName);
        Debug.Assert(stream != null, "Cannot find test data file");
        using var reader = new StreamReader(stream);
        
        var json = reader.ReadToEnd();
        
        // Fake birthdate in old format
        var regex = new Regex(@"""birthDate"":""\d{4}-\d{2}(-\d{2})?""");
        json = regex.Replace(json, @"""birthDate"":""2025-03-19""");
        Assert.That(json, Does.Contain(@"""birthDate"":""2025-03-19"""));

        var mtb = Mtb.FromJson(json);
        var actual = Serialize.ToJson(mtb);
        // Expect new format
        Assert.That(actual, Does.Contain(@"""birthDate"":""2025-03"""));
    }
}