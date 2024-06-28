using System;

class Program
{
    static void Main(string[] args)
    {
        // Nhập độ dài của mảng
        Console.WriteLine("Nhập độ dài của mảng số nguyên N:");
        int n = int.Parse(Console.ReadLine());

        // Khởi tạo mảng số nguyên
        int[] arr = new int[n];

        // Nhập các phần tử của mảng
        Console.WriteLine("Nhập các phần tử của mảng:");
        for (int i = 0; i < n; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        // Tạo đối tượng Services
        Service service = new Service();

        // Biến để kiểm tra xem người dùng có muốn tiếp tục hay không
        bool thoat = false;

        // Vòng lặp để hiển thị menu và xử lý các lựa chọn của người dùng
        while (!thoat)
        {
            // Hiển thị menu
            Console.WriteLine("\n--- MENU ---");
            Console.WriteLine("1. In các số nguyên trong mảng");
            Console.WriteLine("2. In các số nguyên chẵn trong mảng");
            Console.WriteLine("3. In các số nguyên lẻ trong mảng");
            Console.WriteLine("4. Tính tổng các số nguyên có trong mảng");
            Console.WriteLine("5. Tính tổng các số nguyên chẵn có trong mảng");
            Console.WriteLine("6. Tính tổng các số nguyên lẻ có trong mảng");
            Console.WriteLine("7. Tính trung bình cộng các số nguyên có trong mảng");
            Console.WriteLine("8. Tính trung bình cộng các số nguyên chẵn có trong mảng");
            Console.WriteLine("9. Tính trung bình cộng các số nguyên lẻ có trong mảng");
            Console.WriteLine("0. Thoát");

            // Nhập lựa chọn của người dùng
            Console.WriteLine("Nhập lựa chọn của bạn:");
            int choice = int.Parse(Console.ReadLine());

            // Xử lý lựa chọn của người dùng
            switch (choice)
            {
                case 1:
                    service.InMang(arr);
                    break;
                case 2:
                    service.InSoChan(arr);
                    break;
                case 3:
                    service.InSoLe(arr);
                    break;
                case 4:
                    service.TinhTongMang(arr);
                    break;
                case 5:
                    service.TinhTongSoChan(arr);
                    break;
                case 6:
                    service.TinhTongSoLe(arr);
                    break;
                case 7:
                    service.TinhTrungBinhCongMang(arr);
                    break;
                case 8:
                    service.TinhTrungBinhCongSoChan(arr);
                    break;
                case 9:
                    service.TinhTrungBinhCongSoLe(arr);
                    break;
                case 0:
                    thoat = true;
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    break;
            }
        }

        Console.WriteLine("Chương trình đã kết thúc.");
    }
}
