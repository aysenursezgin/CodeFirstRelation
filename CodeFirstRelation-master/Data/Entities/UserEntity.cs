namespace CodeFirstRelation.Data.Entities
{
    public class UserEntity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }

        //Bire Çok Bağlantı
        public List<PostEntity> Post { get; set; }
    }
}
