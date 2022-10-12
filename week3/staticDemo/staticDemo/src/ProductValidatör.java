//ürünlerin kurallara uygun olup olmadığı için kullanılır
public class ProductValidatör {
    static {
        System.out.println("Static Yapıcı Blok Çlıştı");
    }
    public ProductValidatör(){
        System.out.println("Yapıcı Blok Çalıştı");
    }

    public static boolean isValid(Product product) {
        if (product.price>0 && !product.name.isEmpty()){
            return true;
        }else{
            return false;

        }

    }
    public void bisey(){

    }
    public static class BaşkaBirClass{
        public static void Sil(){

        }
    }
}
//inner class
