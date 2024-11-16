namespace CodeFirstRelation.Data.Entities
{
    public class PostEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        //Foreing Key
        public int UserId { get; set; }

        //Bire Bir Bağlantı
        public UserEntity User { get; set; }


    }
}
