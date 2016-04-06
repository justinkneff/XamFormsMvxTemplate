using SQLite.Net.Attributes;

namespace XamForms.MvxTemplate.Core.Model
{
    public class BaseModel
    {
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
    }
}
