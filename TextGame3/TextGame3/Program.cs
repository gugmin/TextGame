using System.Xml.Linq;
using System.Threading;
using static TextGame.Program;
using System.Collections.Generic;
using System.Diagnostics;

namespace TextGame
{
    internal class Program
    {
        private static Character player;
        public static List<Item> shopItem;
        public static List<Item> Inventory;
        public static bool Isequip; //= false;

        //private static Item item;



        static void Main(string[] args)
        {
            Console.Clear();
            GameItemSetting();
            Intro();
            GameStartScene();
            DisplayGameIntro();
        }//Main
        static void Intro()
        {
            //Console.WriteLine("\r\nsdSS_SSSSSSbs    sSSs   .S S.   sdSS_SSSSSSbs    sSSSSs   .S_SSSs     .S_SsS_S.     sSSs  \r\nYSSS~S%SSSSSP   d%%SP  .SS SS.  YSSS~S%SSSSSP   d%%%%SP  .SS~SSSSS   .SS~S*S~SS.   d%%SP  \r\n     S%S       d%S'    S%S S%S       S%S       d%S'      S%S   SSSS  S%S `Y' S%S  d%S'    \r\n     S%S       S%S     S%S S%S       S%S       S%S       S%S    S%S  S%S     S%S  S%S     \r\n     S&S       S&S     S%S S%S       S&S       S&S       S%S SSSS%S  S%S     S%S  S&S     \r\n     S&S       S&S_Ss   SS SS        S&S       S&S       S&S  SSS%S  S&S     S&S  S&S_Ss  \r\n     S&S       S&S~SP    S_S         S&S       S&S       S&S    S&S  S&S     S&S  S&S~SP  \r\n     S&S       S&S      SS~SS        S&S       S&S sSSs  S&S    S&S  S&S     S&S  S&S     \r\n     S*S       S*b     S*S S*S       S*S       S*b `S%%  S*S    S&S  S*S     S*S  S*b     \r\n     S*S       S*S.    S*S S*S       S*S       S*S   S%  S*S    S*S  S*S     S*S  S*S.    \r\n     S*S        SSSbs  S*S S*S       S*S        SS_sSSS  S*S    S*S  S*S     S*S   SSSbs  \r\n     S*S         YSSP  S*S S*S       S*S         Y~YSSY  SSS    S*S  SSS     S*S    YSSP  \r\n     SP                SP            SP                         SP           SP           \r\n     Y                 Y             Y                          Y            Y            \r\n                                                                                          \r\n");
            //Console.WriteLine("\r\n'########:'########:'##::::'##:'########::'######::::::'###::::'##::::'##:'########:\r\n... ##..:: ##.....::. ##::'##::... ##..::'##... ##::::'## ##::: ###::'###: ##.....::\r\n::: ##:::: ##::::::::. ##'##:::::: ##:::: ##:::..::::'##:. ##:: ####'####: ##:::::::\r\n::: ##:::: ######:::::. ###::::::: ##:::: ##::'####:'##:::. ##: ## ### ##: ######:::\r\n::: ##:::: ##...:::::: ## ##:::::: ##:::: ##::: ##:: #########: ##. #: ##: ##...::::\r\n::: ##:::: ##:::::::: ##:. ##::::: ##:::: ##::: ##:: ##.... ##: ##:.:: ##: ##:::::::\r\n::: ##:::: ########: ##:::. ##:::: ##::::. ######::: ##:::: ##: ##:::: ##: ########:\r\n:::..:::::........::..:::::..:::::..::::::......::::..:::::..::..:::::..::........::\r\n");
            for (int i = 0; i < 10; i++)
            {
                Console.SetCursorPosition(10 - i, 0);
                Console.WriteLine(":::::::::'##:::::'##:'########:'##::::::::'######:::'#######::'##::::'##::::::::::::  ");
                Thread.Sleep(10);
                Console.SetCursorPosition(10 - i, 1);
                Console.WriteLine("::::::::: ##:'##: ##: ##.....:: ##:::::::'##... ##:'##.... ##: ###::'###::::::::::::  ");
                Thread.Sleep(10);
                Console.SetCursorPosition(10 - i, 2);
                Console.WriteLine("::::::::: ##: ##: ##: ##::::::: ##::::::: ##:::..:: ##:::: ##: ####'####::::::::::::  ");
                Thread.Sleep(10);
                Console.SetCursorPosition(10 - i, 3);
                Console.WriteLine("::::::::: ##: ##: ##: ######::: ##::::::: ##::::::: ##:::: ##: ## ### ##::::::::::::  ");
                Thread.Sleep(10);
                Console.SetCursorPosition(10 - i, 4);
                Console.WriteLine("::::::::: ##: ##: ##: ##...:::: ##::::::: ##::::::: ##:::: ##: ##. #: ##:::::::::::: ");
                Thread.Sleep(10);
                Console.SetCursorPosition(10 - i, 5);
                Console.WriteLine("::::::::: ##: ##: ##: ##::::::: ##::::::: ##::: ##: ##:::: ##: ##:.:: ##::::::::::::  ");
                Thread.Sleep(10);
                Console.SetCursorPosition(10 - i, 6);
                Console.WriteLine(":::::::::. ###. ###:: ########: ########:. ######::. #######:: ##:::: ##::::::::::::  ");
                Thread.Sleep(10);
                Console.SetCursorPosition(10 - i, 7);
                Console.WriteLine("::::::::::...::...:::........::........:::......::::.......:::..:::::..:::::::::::::  ");
                Thread.Sleep(10);
                Console.SetCursorPosition(10 - i, 8);
                Console.WriteLine("'########:'########:'##::::'##:'########::'######::::::'###::::'##::::'##:'########:");
                Thread.Sleep(10);
                Console.SetCursorPosition(10 - i, 9);
                Console.WriteLine("... ##..:: ##.....::. ##::'##::... ##..::'##... ##::::'## ##::: ###::'###: ##.....::");
                Thread.Sleep(10);
                Console.SetCursorPosition(10 - i, 10);
                Console.WriteLine("::: ##:::: ##::::::::. ##'##:::::: ##:::: ##:::..::::'##:. ##:: ####'####: ##:::::::");
                Thread.Sleep(10);
                Console.SetCursorPosition(10 - i, 11);
                Console.WriteLine("::: ##:::: ######:::::. ###::::::: ##:::: ##::'####:'##:::. ##: ## ### ##: ######:::");
                Thread.Sleep(10);
                Console.SetCursorPosition(10 - i, 12);
                Console.WriteLine("::: ##:::: ##...:::::: ## ##:::::: ##:::: ##::: ##:: #########: ##. #: ##: ##...::::");
                Thread.Sleep(10);
                Console.SetCursorPosition(10 - i, 13);
                Console.WriteLine("::: ##:::: ##:::::::: ##:. ##::::: ##:::: ##::: ##:: ##.... ##: ##:.:: ##: ##:::::::");
                Thread.Sleep(10);
                Console.SetCursorPosition(10 - i, 14);
                Console.WriteLine("::: ##:::: ########: ##:::. ##:::: ##::::. ######::: ##:::: ##: ##:::: ##: ########:");
                Thread.Sleep(10);
                Console.SetCursorPosition(10 - i, 15);
                Console.WriteLine(":::..:::::........::..:::::..:::::..::::::......::::..:::::..::..:::::..::........::\r\n");
                Thread.Sleep(100);
                Console.Clear();
            }
            Console.SetCursorPosition(20, 0);
            Console.WriteLine("\r:::::::::'##:::::'##:'########:'##::::::::'######:::'#######::'##::::'##::::::::::::  " +
                                            "\r\n::::::::: ##:'##: ##: ##.....:: ##:::::::'##... ##:'##.... ##: ###::'###::::::::::::  " +
                                            "\r\n::::::::: ##: ##: ##: ##::::::: ##::::::: ##:::..:: ##:::: ##: ####'####::::::::::::  " +
                                            "\r\n::::::::: ##: ##: ##: ######::: ##::::::: ##::::::: ##:::: ##: ## ### ##::::::::::::  " +
                                            "\r\n::::::::: ##: ##: ##: ##...:::: ##::::::: ##::::::: ##:::: ##: ##. #: ##::::::::::::  " +
                                            "\r\n::::::::: ##: ##: ##: ##::::::: ##::::::: ##::: ##: ##:::: ##: ##:.:: ##::::::::::::  " +
                                            "\r\n:::::::::. ###. ###:: ########: ########:. ######::. #######:: ##:::: ##::::::::::::  " +
                                            "\r\n::::::::::...::...:::........::........:::......::::.......:::..:::::..:::::::::::::  " +
                                            "\r\n'########:'########:'##::::'##:'########::'######::::::'###::::'##::::'##:'########:" +
                                            "\r\n... ##..:: ##.....::. ##::'##::... ##..::'##... ##::::'## ##::: ###::'###: ##.....::" +
                                            "\r\n::: ##:::: ##::::::::. ##'##:::::: ##:::: ##:::..::::'##:. ##:: ####'####: ##:::::::" +
                                            "\r\n::: ##:::: ######:::::. ###::::::: ##:::: ##::'####:'##:::. ##: ## ### ##: ######:::" +
                                            "\r\n::: ##:::: ##...:::::: ## ##:::::: ##:::: ##::: ##:: #########: ##. #: ##: ##...::::" +
                                            "\r\n::: ##:::: ##:::::::: ##:. ##::::: ##:::: ##::: ##:: ##.... ##: ##:.:: ##: ##:::::::" +
                                            "\r\n::: ##:::: ########: ##:::. ##:::: ##::::. ######::: ##:::: ##: ##:::: ##: ########:" +
                                            "\r\n:::..:::::........::..:::::..:::::..::::::......::::..:::::..::..:::::..::........::\r\n");
            //Console.WriteLine("\r\n            ██╗    ██╗███████╗██╗      ██████╗ ██████╗ ███╗   ███╗            \r\n            ██║    ██║██╔════╝██║     ██╔════╝██╔═══██╗████╗ ████║            \r\n            ██║ █╗ ██║█████╗  ██║     ██║     ██║   ██║██╔████╔██║            \r\n            ██║███╗██║██╔══╝  ██║     ██║     ██║   ██║██║╚██╔╝██║            \r\n            ╚███╔███╔╝███████╗███████╗╚██████╗╚██████╔╝██║ ╚═╝ ██║            \r\n             ╚══╝╚══╝ ╚══════╝╚══════╝ ╚═════╝ ╚═════╝ ╚═╝     ╚═╝            \r\n                                                                              \r\n████████╗███████╗██╗  ██╗████████╗ ██████╗  █████╗ ███╗   ███╗███████╗        \r\n╚══██╔══╝██╔════╝╚██╗██╔╝╚══██╔══╝██╔════╝ ██╔══██╗████╗ ████║██╔════╝        \r\n   ██║   █████╗   ╚███╔╝    ██║   ██║  ███╗███████║██╔████╔██║█████╗          \r\n   ██║   ██╔══╝   ██╔██╗    ██║   ██║   ██║██╔══██║██║╚██╔╝██║██╔══╝          \r\n   ██║   ███████╗██╔╝ ██╗   ██║   ╚██████╔╝██║  ██║██║ ╚═╝ ██║███████╗        \r\n   ╚═╝   ╚══════╝╚═╝  ╚═╝   ╚═╝    ╚═════╝ ╚═╝  ╚═╝╚═╝     ╚═╝╚══════╝        \r\n                                                                              \r\n");
            Thread.Sleep(1000);
            Console.WriteLine("숫자 '0' 을 눌러 시작하세요");
            int input = CheckValidInput(0, 0);
            switch (input)
            {
                case 0:
                    Console.Clear();
                    break;
            }
        }

        static void GameItemSetting()
        {
            // 상점 아이템 정보 세팅
            Item shopItem01 = new Item(" 나무 검      ", 4, 0, 50, false);
            Item shopItem02 = new Item(" 무쇠 창      ", 6, 0, 100, false);
            Item shopItem03 = new Item(" 황금 검      ", 8, 0, 150, false);
            Item shopItem04 = new Item(" 다이아 검  ", 10, 0, 200, false);
            Item shopItem05 = new Item(" 티타늄 검  ", 100, 0, 50000, false);
            Item shopItem06 = new Item(" 비브라늄 검", 150, 0, 70000, false);
            Item shopItem07 = new Item(" 판자 갑옷  ", 0, 4, 50, false);
            Item shopItem08 = new Item(" 무쇠 갑옷  ", 0, 6, 100, false);
            Item shopItem09 = new Item(" 황금 갑옷  ", 0, 8, 150, false);
            Item shopItem10 = new Item("다이아 갑옷  ", 0, 10, 200, false);
            Item shopItem11 = new Item("티타늄 갑옷 ", 0, 100, 50000, false);
            Item shopItem12 = new Item("비브라늄 갑옷", 0, 150, 70000, false);
            Item shopItem13 = new Item("다이아 반지", 100, 100, 100000, false);


            shopItem = new List<Item>();

            shopItem.Add(shopItem01);
            shopItem.Add(shopItem02);
            shopItem.Add(shopItem03);
            shopItem.Add(shopItem04);
            shopItem.Add(shopItem05);
            shopItem.Add(shopItem06);
            shopItem.Add(shopItem07);
            shopItem.Add(shopItem08);
            shopItem.Add(shopItem09);
            shopItem.Add(shopItem10);
            shopItem.Add(shopItem11);
            shopItem.Add(shopItem12);
            shopItem.Add(shopItem13);
        }

        static void GameStartScene()
        {
            // 캐릭터 이름 세팅
            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이름을 입력하세요.");
            Console.WriteLine();
            string playerName = Console.ReadLine();
            Console.WriteLine("\n");
            Console.WriteLine($"이름 :{playerName}");
            Console.Clear();


            // 캐릭터 직업 세팅
            Console.WriteLine("원하는 직업을 선택하세요.");
            Console.WriteLine();
            Console.WriteLine("1. 전사 : 공격과 방어에 밸런스가 좋고 초기 체력이 높습니다.\n");
            Console.WriteLine("2. 궁수 : 공격력이 강한 대신 방어력과 체력이 낮습니다.\n");
            Console.WriteLine("3. 도적 : 초기스텟이 낮은 대신 추가 소지금이 있습니다.\n");

            int input = CheckValidInput(1, 3);

            switch (input)
            {
                case 1:
                    player = new Character($"{playerName}", "전사", 1, 10, 10, 150, 1500);
                    break;
                case 2:
                    player = new Character($"{playerName}", "궁수", 1, 15, 5, 80, 1500);
                    break;
                case 3:
                    player = new Character($"{playerName}", "도적", 1, 7, 7, 77, 7777);
                    break;
                default:
                    Console.WriteLine("잘못된 선택입니다.");
                    break;
            }

        }//GameStartScene()

        static void DisplayGameIntro()
        {
            Console.Clear();

            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 전전으로 들어가기 전 활동을 할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("1. 상태보기");
            Console.WriteLine("2. 인벤토리");
            Console.WriteLine("3. 상점\n");
            Console.WriteLine("원하시는 행동을 입력해주세요.");

            int input = CheckValidInput(1, 3);
            switch (input)
            {
                case 1:
                    DisplayMyInfo();
                    break;

                case 2:
                    DisplayInventory();
                    break;

                case 3:
                    DisplayShop(player, shopItem);
                    break;
            }
        }//DisplayGameIntro()

        static void DisplayMyInfo()
        {
            Console.Clear();

            Console.WriteLine("상태보기");
            Console.WriteLine("캐릭터의 정보를 표시합니다.");
            Console.WriteLine();
            Console.WriteLine($"Lv.{player.Level}");
            Console.WriteLine($"{player.Name}({player.Job})");
            Console.WriteLine($"공격력 :{player.Atk}");   // (+ {player.equippedItem.Atk})");
            Console.WriteLine($"방어력 : {player.Def}");  // (+ {player.equippedItem.Atk})");
            Console.WriteLine($"체력 : {player.Hp}");
            Console.WriteLine($"Gold : {player.Gold} G");
            Console.WriteLine();
            Console.WriteLine("0. 나가기");

            int input = CheckValidInput(0, 0);
            switch (input)
            {
                case 0:
                    DisplayGameIntro();
                    break;
            }
        }//DisplayMyInfo()

        static void DisplayInventory() //인벤토리
        {
            //ItemList a = new ItemList();
            //ArmorList b = new ArmorList();
            Console.Clear();

            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            for (int i = 0; i < player.Inventory.Count; i++)
            {
                Console.WriteLine($"{player.Inventory[i]}");
            }
            //var table = new ConsoleTable(" 이름 ", " 공격력 ", " 방어력 ", "가격");
            //for (int i = 0; i < a.items1.Count; i++)
            //{
            //    table.AddRow($"{Item.Name[i]}", $"{ATK[i]}", $"{DEF[i]}", $"{Price[i]}");
            //}
            //table.Write();
            //for (int i = 0; i < b.armors1.Count; i++)
            //{
            //    Console.WriteLine($"{i + 1} : {b.armors1[i]}");
            //}
            Console.WriteLine();
            Console.WriteLine("1. 장착관리");
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("원하시는 행동을 입력해주세요.");

            int input = CheckValidInput(0, 1);
            switch (input)
            {
                case 0:
                    DisplayGameIntro();
                    break;
                case 1:
                    DisplayEquipment();
                    break;
                default:
                    Console.WriteLine("잘못된 번호를 입력하셨습니다!");
                    break;
            }
        }//DisplayInventory()

        static void DisplayEquipment()  //장착관리
        {
            //ItemList a = new ItemList();
            //ArmorList b = new ArmorList();
            Isequip = false;
            Console.Clear();

            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
            Console.WriteLine();
            Console.WriteLine("[아이템 목록]");
            for (int i = 0; i < player.Inventory.Count; i++)
            {
                Console.WriteLine($"{i + 1} : {player.Inventory[i]}");
            }
            //for (int i = 0; i < b.armors1.Count; i++)
            //{
            //    Console.WriteLine($"{i + 1} : {b.armors1[i]}");
            //}
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("0. 나가기");
            Console.WriteLine();
            Console.WriteLine("장착을 원하는 번호를 입력해주세요.");

            if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 1 && choice <= player.Inventory.Count)
            {
                Item selectedItem = player.Inventory[choice - 1];
                player.equippedItem = selectedItem;
                if (selectedItem.Isequip == false)
                {
                    // 아이템을 처음 장착하는 경우 selectedItem != player.equippedItem
                    //  player.equippedItem = selectedItem;
                    selectedItem.Isequip = true;
                    Console.WriteLine($"{selectedItem.Name}을(를) 장착했습니다.");
                    player.Atk += selectedItem.Atk;
                    player.Def += selectedItem.Def;
                    Thread.Sleep(600);
                    DisplayEquipment();
                }
                else
                {
                    // 이미 장착 중인 아이템이 선택된 경우 selectedItem == player.equippedItem
                    player.equippedItem = null;
                    selectedItem.Isequip = false;
                    Console.WriteLine($"{selectedItem.Name}을(를) 장착 해제했습니다.");
                    player.Atk -= selectedItem.Atk;
                    player.Def -= selectedItem.Def;
                    Thread.Sleep(600);
                    DisplayEquipment();
                }
            }
            else if (choice == 0)
            {
                Console.WriteLine("나가기");
                DisplayInventory();
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다");
                Thread.Sleep(500);
                DisplayEquipment();
            }
        }//DisplayEquipment()

        static void DisplayShop(Character player, List<Item> shopItem)  //상점
        {
            //ItemList a = new ItemList();
            //ArmorList b = new ArmorList();
            Console.Clear();

            Console.WriteLine("상점");
            Console.WriteLine($"구매 할 물품을 선택하세요.     {player.Gold}  G");
            Console.WriteLine("\n");
            Console.WriteLine("[아이템 목록]");
            for (int i = 0; i < shopItem.Count; i++)
            {
                Console.WriteLine($"{i + 1} : {shopItem[i]}");
            }
            //for (int i = 0; i < b.armors1.Count; i++)
            //{
            //    Console.WriteLine($"{i + 1} : {b.armors1[i]}");
            //}
            Console.WriteLine();
            Console.WriteLine("구입할 아이템을 선택하세요");
            Console.WriteLine("20000. 판매");
            Console.WriteLine("0. 나가기");
            int.TryParse(Console.ReadLine(), out int choice);
            if (choice >= 0 && choice <= shopItem.Count)
            {
                if (choice == 0)
                {
                    DisplayGameIntro();
                }

                Item selectedShopItem = shopItem[choice - 1];

                if (player.Gold >= selectedShopItem.Price)
                {
                    // 플레이어의 소지금에서 아이템 가격을 차감
                    player.Gold -= selectedShopItem.Price;

                    // 아이템을 플레이어의 인벤토리에 추가
                    player.Inventory.Add(selectedShopItem);
                    shopItem.Remove(selectedShopItem);

                    Console.WriteLine($"{selectedShopItem.Name}을(를) 구입했습니다. 남은 골드: {player.Gold}");
                    Thread.Sleep(600);
                    DisplayShop(player, shopItem);
                }
                else
                {
                    Console.WriteLine("골드가 부족하여 아이템을 구입할 수 없습니다.");
                    Thread.Sleep(600);
                    DisplayShop(player, shopItem);
                }
            }
            else if (choice == 20000)
            {
                DisplaySellShop(player, Inventory);
            }
            else
            {
                Console.WriteLine("잘못된 선택입니다.");
                Thread.Sleep(500);
                DisplayShop(player, shopItem);
            }
        }//DisplayShop()

        static void DisplaySellShop(Character player, List<Item> Inventory)  //상점 - 판매
        {
            Console.Clear();

            Console.WriteLine("상점");
            Console.WriteLine($"판매 할 물품을 선택하세요.     {player.Gold}  G");
            Console.WriteLine("\n");
            Console.WriteLine("[아이템 목록]");
            for (int i = 0; i < player.Inventory.Count; i++)
            {
                Console.WriteLine($"{i + 1} : {player.Inventory[i]}");
            }
            Console.WriteLine();
            Console.WriteLine("판매할 아이템을 선택하세요");
            Console.WriteLine("0. 나가기");

            if (int.TryParse(Console.ReadLine(), out int choice) && choice >= 0 && choice <= player.Inventory.Count)
            {
                if (choice == 0)
                {
                    DisplayShop(player, shopItem);
                }

                Item selectedSellShopItem = player.Inventory[choice - 1];

                if (selectedSellShopItem.Price >= 0)
                {
                    // 플레이어의 소지금에서 아이템 가격을 더함
                    player.Gold += selectedSellShopItem.Price;
                    player.equippedItem = null;
                    selectedSellShopItem.Isequip = false;
                    player.Atk -= selectedSellShopItem.Atk;
                    player.Def -= selectedSellShopItem.Def;

                    // 아이템을 플레이어의 인벤토리에 삭제
                    shopItem.Add(selectedSellShopItem);
                    player.Inventory.Remove(selectedSellShopItem);

                    Console.WriteLine($"{selectedSellShopItem.Name}을(를) 판매했습니다. 남은 골드: {player.Gold}");
                    Thread.Sleep(600);
                    DisplaySellShop(player, Inventory);
                }
            }
            else
            {
                Console.WriteLine("잘못된 선택입니다.");
                Thread.Sleep(500);
                DisplayShop(player, Inventory);
            }
        }//DisplaySellShop()


        //input setting
        static int CheckValidInput(int min, int max)
        {
            while (true)
            {
                string input = Console.ReadLine();

                bool parseSuccess = int.TryParse(input, out var ret);
                if (parseSuccess)
                {
                    if (ret >= min && ret <= max)
                        return ret;
                }

                Console.WriteLine("잘못된 입력입니다.");
                Thread.Sleep(500);
            }
        }//CheckValidInput()

        public class Character
        {
            public string Name { get; }
            public string Job { get; }
            public int Level { get; set; }
            public int Atk { get; set; }
            public int Def { get; set; }
            public int Hp { get; set; }
            public int Gold { get; set; }
            public List<Item> Inventory { get; set; }
            public Item equippedItem { get; set; }

            public Character(string name, string job, int level, int atk, int def, int hp, int gold)
            {
                Name = name;
                Job = job;
                Level = level;
                Atk = atk;
                Def = def;
                Hp = hp;
                Gold = gold;
                Inventory = new List<Item>();   // 인벤토리
                Inventory.Add(new Item("나무 몽둥이", 2, 0, 50, false));
                Inventory.Add(new Item("냄비 뚜껑   ", 0, 2, 50, false));
                equippedItem = null;  //장착했는지 안했는지 알려주는거

            }
        }// Character
        //public interface Item
        //{
        //    string Name { get; set; }
        //    int Atk { get; set; }
        //    int Def { get; set; }
        //    int Price { get; set; }
        //}//interface Item

        public class Item
        {
            public string Name { get; set; }
            public int Atk { get; set; }
            public int Def { get; set; }
            public int Price { get; set; }
            public bool Isequip { get; set; } // [E] 표시


            public Item(string name, int atk, int def, int price, bool equip)
            {
                Name = name;
                Atk = atk;
                Def = def;
                Price = price;
                Isequip = equip;
            }

            public override string ToString()
            {
                if (Isequip == true && Price >= 100)
                {
                    return ($" [E] {Name}\t  | 공격력 +{Atk}\t  | 방어력 +{Def}\t  |  {Price}\t G ");
                }
                else if (Isequip == true)
                {
                    return ($" [E] {Name}\t  | 공격력 +{Atk}\t  | 방어력 +{Def}\t  |  {Price}\t\t G ");
                }
                else if (Isequip == false && Price >= 100)
                {
                    return ($" {Name}\t  | 공격력 +{Atk}\t  | 방어력 +{Def}\t  |  {Price}\t G ");
                }
                else
                    return ($" {Name}\t  | 공격력 +{Atk}\t  | 방어력 +{Def}\t  |  {Price}\t\t G ");
            }

        }//class Item

        //public class ItemList
        //{
        //    private List<Item> items;

        //    public List<Item> items1 { get { return items; } }

        //    public ItemList()
        //    {
        //        items = new List<Item>
        //        {
        //            new Item("나무 검", 4, 0, 50),
        //            new Item("무쇠 창", 6, 0, 10),
        //            new Item("황금 검", 8, 0, 150),
        //            new Item("다이아 검", 10, 0, 200),
        //            new Item("판자 갑옷", 0, 4, 50),
        //            new Item("무쇠 갑옷", 0, 6, 100),
        //            new Item("황금 갑옷", 0, 8, 150),
        //            new Item("다이아 갑옷", 0, 10, 200)
        //        };
        //    }
        //}//class WeaponList

        //public class Armor : Item
        //{
        //    public string Name { get; set; }
        //    public int Atk { get; set; }
        //    public int Def { get; set; }
        //    public int Price { get; set; }

        //    public Armor(string name, int atk, int def, int price)
        //    {
        //        Name = name;
        //        Atk = atk;
        //        Def = def;
        //        Price = price;
        //    }

        //    public override string ToString()
        //    {
        //        return $"[E]{Name,-15} | 방어력 +{Def} | {Price}";
        //    }
        //}//class Armor

        //public class ArmorList
        //{
        //    private List<Armor> armors;
        //    public List<Armor> armors1 { get { return armors; } }

        //    public ArmorList()
        //    {
        //        armors = new List<Armor>
        //        {
        //            new Armor("판자 갑옷", 0, 4, 50),
        //            new Armor("무쇠 갑옷", 0, 6, 100),
        //            new Armor("황금 갑옷", 0, 8, 150),
        //            new Armor("다이아 갑옷", 0, 10, 200)
        //        };
        //    }
        //}//class ArmorList

    }//~
}