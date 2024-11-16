# CodeFirstRelation

Bu proje, Entity Framework Core kullanarak Code First yaklaşımıyla bir kullanıcı ve gönderi ilişkisi (birden çoğa ilişki) içeren bir veritabanı oluşturur.

## Tablolar

- **User**: Kullanıcı bilgilerini tutar.
  - Id: int (PK)
  - Username: string
  - Email: string
  - Posts: List of Posts (Bir kullanıcıya ait gönderiler)

- **Post**: Kullanıcı tarafından yazılan gönderileri tutar.
  - Id: int (PK)
  - Title: string
  - Content: string
  - UserId: int (FK)

## Kurulum

1. Gerekli paketleri yükleyin:
    ```bash
    dotnet restore
    ```

2. Migration ekleyin:
    ```bash
    dotnet ef migrations add InitialCreate
    ```

3. Veritabanını güncelleyin:
    ```bash
    dotnet ef database update
    ```

## Kullanım

Kullanıcı ve gönderi eklemek ve verileri okumak için `Program.cs` dosyasını kullanın.

## Lisans

Bu proje MIT lisansı ile lisanslanmıştır.
