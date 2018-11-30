namespace BIMReports.Forms
{
    public interface IProgramDependencyProperty
    {
        bool Equals(object obj);
        int GetHashCode();
        string ToString();
    }
}