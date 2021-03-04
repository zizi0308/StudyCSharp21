using System;
using System.Collections.Generic;
using System.IO;

namespace AddressBookApp
{


    class MainApp
    {
        static void Main(string[] args)
        {
            try
            {
                AddressManager manager = new AddressManager
                {
                    listAddress = new List<AddressInfo>()
                };

                DataFileManager fileManager = new DataFileManager();
                manager.listAddress = fileManager.ReadData();

                while (true)
                {
                    Console.Clear();
                    // Console.WriteLine(Environment.CurrentDirectory); // 내가 실행하고있는 파일 찾을 때 씀 콘솔에서 드래그 엔터하면 복사
                    manager.PrintMenu();
                    int menuNum = manager.SelectMenu();

                    switch (menuNum)
                    {
                        case 1: // 주소입력 화면 전환
                            Console.Clear();
                            manager.InputAddress();

                            break;
                        case 2: // 주소검색
                            Console.Clear();
                            manager.SearchAddress();

                            break;
                        case 3: // 주소수정
                            Console.Clear();
                            manager.UpdateAddress();

                            break;
                        case 4: // 주소삭제
                            Console.Clear();
                            manager.DeleteAddress();

                            break;
                        case 5: // 주소전체 출력
                            Console.Clear();
                            manager.PrintAllAddress();

                            break;
                        case 6: // 종료
                            fileManager.WriteData(manager.listAddress);
                            Environment.Exit(0);
                            break;
                        default: // 0은 여기서 처리됨
                                 // 아무 로직 없음
                            break;
                    }

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"에외발생 {ex.Message}");
            }
            
        }

    }
}
