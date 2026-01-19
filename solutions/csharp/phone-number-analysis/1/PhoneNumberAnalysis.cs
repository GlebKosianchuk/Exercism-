public static class PhoneNumber
{
    public static (bool IsNewYork, bool IsFake, string LocalNumber) Analyze(string phoneNumber)
    {
        var item1 = phoneNumber[..3];
        var item2 = phoneNumber.Substring(4, 3);
        var item3 = phoneNumber.Substring(8, 4);
        
        return (item1 == "212", item2 == "555", item3);
    }

    public static bool IsFake((bool IsNewYork, bool IsFake, string LocalNumber) phoneNumberInfo) =>
        phoneNumberInfo.IsFake;
}
