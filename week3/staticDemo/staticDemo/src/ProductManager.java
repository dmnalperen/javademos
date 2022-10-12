public class ProductManager {
    static {
        System.out.println("Static Yapıcı Blok Çalıştı");
    }
    public void add(Product product) {
        if (ProductValidatör.isValid(product)) {
            System.out.println("Eklendi");
        } else {
            System.out.println("Ürün Bilgileri Geçersizdir");
        }


    }
}
