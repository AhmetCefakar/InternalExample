Bu Dll altında birden çok 'namespace' tanımlandı ve bu namespace'ler altındaki internal tanımlı üyeler(class,enum, struct vb.)
arasında birbirlerini görme durumları incelenmiştir.

Alttaki microsoft'un kendi sitesindeki açıklamada 'internal' için zaten açıkça aynı 'assembly' içerisinden erişilebilir şeklinde açıklıyor.

internal
The type or member can be accessed by any code in the same assembly, but not from another assembly.


Bana burada sizin 'assembly' yerine 'namespace' kelimesini kullanıyormuşsunuz gibi geliyor, sonuçta bir 'assably' altında yüzlerce farklı
'namespace' tanımı yapılabilir.
.Net platformunda her bir proje 'assably' olarak adlandırılıyor.

Ben bu örnek 'solution' altında sadece bir tane 'dll' projesi ekledim ve 
üç farklı namespace tanımladım ve bu namespace'ler altında tanımlı sınıfların birbirlerini görme durumlarını inceledim.


En nihayetinde zaten 'internal' tanımlı bir üyeye kendi projesinin referans edildiği bir proje altından erişilemez.
Umarım asıl sormak istediğim aklıma takılan noktayı anlatabilmişimdir.

İlginize teşekkür ederim.
