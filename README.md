# MyZoo
Simple Zoo to learn C#

Đây là chương trình mô phỏng cuộc sống tại sở thú Z. Sở thú Z có rất nhiều loài khác nhau. Mỗi một cá thể đều được theo dõi các số liệu sau (mã cá thể, tên, giới tính, cân nặng, chiều dài , thể lực (double)).
Danh sách cụ thể của mỗi loài động, thực vật trong sở thú được ghi nhận theo bảng sau:

| Tên loài        | Giới           | Mô tả  |
| ------------- |:-------------:| -----:|
| Rabbit      | Động vật | Thỏ chạy rất nhanh. Nếu bị bỏ đói, thể lực của thỏ giảm 50%. Thỏ sinh sản rất nhanh, sau 5 ngày, số lượng thỏ tăng lên gấp đôi. |
| Wolf      | Động vật      |   Chó sói có khả năng săn mồi theo bầy đàn rất tốt. Chúng có thể chịu được điều kiện thời tiết khắc nghiệt. Khi gặp thời tiết lạnh giá, thể lực của chúng giảm đi 2% . Món ăn của chúng là các loài động vật khác (trừ đại bàng). Nếu bị bỏ đói, thể lực của sói giảm 50%. Mỗi bữa ăn sẽ giúp chúng +2% cân nặng và +5 thể lực. Sau 10 ngày, sói sinh thêm 2 cá thể. |
| Eagle | Động vật | Đại bàng được nuôi trong những chiếc lồng lớn, do nó có khả năng bay rất xa. Một con đại bàng sẽ giảm đi 20% thể lực với mỗi 5 Km bay được. Đại bàng thích ăn thịt thỏ, mỗi con thỏ sẽ cung cấp 2% cân nặng + 2% chiều dài cơ thể. Nếu bị bỏ đói, thể lực của đại bàng giảm 50%. Đại bàng thích gây chiến với sói. Sau khi gây chiến, sói sẽ giảm 20% thể lực, đại bàng giảm 5% thể lực. Sau 10 ngày, đại bàng sinh thêm 2 cá thể. |
| Grass | Động vật | Cỏ dại cung cấp 5% thể lực cho mỗi KG cỏ được một loài động vật hấp thụ. Sau khi trời mưa, cỏ sẽ tăng 5% khối lượng của nó. Cỏ bị giảm 20% thể lực với mỗi ngày trời nắng, giảm 10% cho mỗi ngày trời lạnh. Sau mỗi ngày trời mưa, số lượng cỏ tăng thêm 20% tổng số cá thể cỏ hiện tại. |

Chương trình cho phép người dùng xem sự phát triển của sở thú theo từng ngày. Chương trình sẽ tự động phát sinh một số lượng cá thể của mỗi loài ban đầu. Mỗi một ngày trôi qua, người dùng được phép tương tác với sở thú bằng cách cho thỏ ăn (bao nhiêu cỏ?), cho sói/đại bàng ăn (bao nhiêu thỏ?). Thời tiết (bình thường, nắng, mưa, lạnh) sẽ ngẫu nhiên ảnh hưởng đến sở thú sau khi người dùng cho ăn. Đôi khi, đại bàng sẽ gây chiến với sói.
Một cá thể sẽ chết nếu thể lực < 5.
Một loài sẽ tuyệt chủng nếu không còn cá thể nào thuộc loài đó trong sở thú.
Mô phỏng sẽ kết thúc nếu tất cả các loài bị tuyệt chủng.
