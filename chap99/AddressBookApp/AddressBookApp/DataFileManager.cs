using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AddressBookApp
{
    class DataFileManager
    {
        // 텍스트 파일에서 저장된 주소록을 불러온다(파일로드)
        const string dataFileName = "address.dat";

        // D:\Sources\Gitrepository\StudyCSharp21\chap99\AddressBookApp\AddressBookApp\bin\Debug\netcoreapp3.1

        public List<AddressInfo> ReadData()
        {
            var listReult = new List<AddressInfo>();
            string filePath = Environment.CurrentDirectory + "\\" + dataFileName; // 데이터파일 위치
            StreamReader sr = new StreamReader(new FileStream(filePath, FileMode.Open, FileAccess.Read));
            while (sr.EndOfStream == false)
            {
                var temp = sr.ReadLine();
                // temp 잘라서 listReult에 할당 manager.listAddress(주소록 담을 컬렉션)가 여기 없으므로 manager.listAddress을 의미하는 파라미터 값(param)을 넣어줌
                var splits = temp.Split("|");
                listReult.Add(new AddressInfo() { Name = splits[0], Phone = splits[1], Address = splits[2] });
            }
            sr.Close();

            return listReult;
        }
        public void WriteData(List<AddressInfo> list)
        {
            var filePath = Environment.CurrentDirectory + "\\" + dataFileName; // 데이터파일 위치
            // 주소록을 다시 파일에 씀

            StreamWriter sw = new StreamWriter(new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write));
            if (list.Count > 0) // 안에 리스트 데이터가 있으면(값이 0이 아니면)
            {
                foreach (var item in list)
                {
                    sw.WriteLine($"{item.Name}|{item.Phone}|{item.Address}");
                }
            }
            sw.Close(); // 파일저장을 위한 처리

        }
    }
}
