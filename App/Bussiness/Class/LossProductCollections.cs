using System.Data;

namespace Bussiness
{
    public class LossProductCollections
    {
        Database.LossProductCollections lossProductCollections = new Database.LossProductCollections();

        private int ID;
        private string PRODUCT;
        private decimal WHEIGTH; // peso
        private string REMOVAL_DATE;

        public int id
        {
            get { return ID; }
            set { ID = value; }
        }

        public string product
        {
            get { return PRODUCT; }
            set { PRODUCT = value; }
        }

        public decimal wheigth
        {
            get { return WHEIGTH; }
            set { WHEIGTH = value; }
        }

        public string removal_date
        {
            get { return REMOVAL_DATE; }
            set { REMOVAL_DATE = value; }
        }

        string _sql;

        public void Save()
        {
            lossProductCollections.id = this.id;
            lossProductCollections.product = this.product;
            lossProductCollections.wheigth = this.wheigth;
            lossProductCollections.removal_date = this.removal_date;

            lossProductCollections.Save();
        }

        public void Delete(int id)
        {
            lossProductCollections.Delete(id);
        }
        
        public DataTable FindAllByDate(string date, string product = null)
        {
            return lossProductCollections.FindAllByDate(date, product);
        }
        
        public DataTable FindAllByDateSumWheigth(string date, string product = null)
        {
            return lossProductCollections.FindAllByDateSumWheigth(date, product);
        }
        
        public DataTable FindById(int id)
        {
            return lossProductCollections.FindById(id);
        }

        public DataTable FindBetween(string dateInitial, string dateEnd)
        {
            return lossProductCollections.FindBetween(dateInitial, dateEnd);           
        }
        
        public DataTable FindAllProduct()
        {
            return lossProductCollections.FindAllProduct();           
        }
    }
}
