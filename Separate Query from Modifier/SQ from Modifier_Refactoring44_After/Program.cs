using System;

namespace Solution_SeparateQueryFromModifier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "An", "Bình", "Kẻ xấu", "Nguyễn Văn A" };

            // Client có thể chọn chỉ tìm kiếm, hoặc chỉ gửi cảnh báo, hoặc cả hai.
            string found = FindSuspect(people);
            SendAlertIfSuspectFound(people);

            Console.WriteLine("Found: " + found);
        }

        // --- Query: Chỉ trả về dữ liệu, không thay đổi trạng thái ---
        static string FindSuspect(string[] people)
        {
            foreach (var person in people)
            {
                if (person.Equals("Kẻ xấu"))
                {
                    return "Kẻ xấu";
                }
            }
            return "";
        }

        // --- Modifier: Chỉ thay đổi trạng thái, không trả về dữ liệu ---
        static void SendAlertIfSuspectFound(string[] people)
        {
            if (!string.IsNullOrEmpty(FindSuspect(people)))
            {
                SendAlert();
            }
        }
        static void SendAlert() { Console.WriteLine("Alert sent!"); }
    }
}