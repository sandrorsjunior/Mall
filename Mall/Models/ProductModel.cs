
namespace Mall.Models
{
    class ProductModel
    {
        private DateTime _dateCreation;
        public long id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public float value { get; set; }
        public int quantite { get; set; } = 0;
        
        public ProductModel()
        {
            this._dateCreation = DateTime.Now;
        }

        public DateTime getDateCreation()
        {
            return this._dateCreation;
        }

        public string[] getAllAttrLikeStringArry()
        {
            string[] arr = { $"{this.id}", $"{this.name}", $"{this.description}", $"{this.value}", $"{this.quantite}" };
            return arr;
        }

    }
}
