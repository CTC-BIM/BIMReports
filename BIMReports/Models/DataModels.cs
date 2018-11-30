namespace BIMReports.Models
{
    class DataModels
    {
    }
    public class UserLogin
    {
        private int _UserID;

        public int UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }

        private string _UserName;

        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        public UserLogin()
        {

        }

        public UserLogin(int id, string UserName)
        {
            this._UserID = id;
            this._UserName = UserName;
        }

    }
}