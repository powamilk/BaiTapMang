using System;
using System.Linq;

public class Service
{
    public void InMang(int[] arr)
    {
        Console.WriteLine("Các số nguyên trong mảng: " + string.Join(", ", arr));
    }

    public void InSoChan(int[] arr)
    {
        int[] evenNumbers = arr.Where(x => x % 2 == 0).ToArray();
        Console.WriteLine("Các số nguyên chẵn trong mảng: " + string.Join(", ", evenNumbers));
    }

    public void InSoLe(int[] arr)
    {
        int[] oddNumbers = arr.Where(x => x % 2 != 0).ToArray();
        Console.WriteLine("Các số nguyên lẻ trong mảng: " + string.Join(", ", oddNumbers));
    }

    public void TinhTongMang(int[] arr)
    {
        int sumAll = arr.Sum();
        Console.WriteLine("Tổng các số nguyên có trong mảng: " + sumAll);
    }

    public void TinhTongSoChan(int[] arr)
    {
        int[] evenNumbers = arr.Where(x => x % 2 == 0).ToArray();
        int sumEven = evenNumbers.Sum();
        Console.WriteLine("Tổng các số nguyên chẵn có trong mảng: " + sumEven);
    }

    public void TinhTongSoLe(int[] arr)
    {
        int[] oddNumbers = arr.Where(x => x % 2 != 0).ToArray();
        int sumOdd = oddNumbers.Sum();
        Console.WriteLine("Tổng các số nguyên lẻ có trong mảng: " + sumOdd);
    }

    public void TinhTrungBinhCongMang(int[] arr)
    {
        double avgAll = arr.Average();
        Console.WriteLine("Trung bình cộng các số nguyên có trong mảng: " + avgAll);
    }

    public void TinhTrungBinhCongSoChan(int[] arr)
    {
        int[] evenNumbers = arr.Where(x => x % 2 == 0).ToArray();
        double avgEven = evenNumbers.Any() ? evenNumbers.Average() : 0;
        Console.WriteLine("Trung bình cộng các số nguyên chẵn có trong mảng: " + avgEven);
    }

    public void TinhTrungBinhCongSoLe(int[] arr)
    {
        int[] oddNumbers = arr.Where(x => x % 2 != 0).ToArray();
        double avgOdd = oddNumbers.Any() ? oddNumbers.Average() : 0;
        Console.WriteLine("Trung bình cộng các số nguyên lẻ có trong mảng: " + avgOdd);
    }
}
