using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace CSharp._20220514.상속4
{
	public class VendingMachine
	{
		// (메뉴, 가격), (결제 금액, 거스름돈), 선택된 메뉴
		private Dictionary<string, int> menu = new Dictionary<string, int>();
		private int money = 0;
		private string selectedMenu = "";

		public VendingMachine()
		{
			menu.Add("포카리", 1400);
			menu.Add("커피", 1200);
			menu.Add("생수", 500);
			menu.Add("2% 복숭아", 1200);
			menu.Add("콜라", 1500);
		}

		public void UsingMachine()
		{
			WaitForUserInput();
		}

		public void ShowAllMenu()
		{
			int menuNum = 1;
			foreach (string key in menu.Keys)
			{
				Console.WriteLine("- {0}. {1}\t/ {2:D4}원", menuNum++, key, menu[key]);
			}
		}

		private void WaitForUserInput()
		{
			ShowAllMenu();

			Console.WriteLine("원하는 메뉴의 번호 또는 이름을 입력해주세요: ");
			string input = Console.ReadLine();

			Regex regex = new Regex(/*이스케이프 문자 사용 안함*/@"^[0-9]+$");
			if (regex.IsMatch(input))
			{
				SelectInputMenu(int.Parse(input));
			}
			else
			{
				SelectInputMenu(input);
			}
		}

		private void SelectInputMenu(int input)
		{
			input -= 1;

			if (!(0 <= input && input < menu.Count))
			{
				Console.WriteLine("{0}이라는 번호는 존재하지 않습니다!", input + 1);
				return;
			}

			SelectInputMenu(menu.ElementAt(input).Key);
		}

		private void SelectInputMenu(string input)
		{
			if (!menu.ContainsKey(input))
			{
				Console.WriteLine("{0}(이)라는 이름을 가진 음료는 존재하지 않습니다!", input);
				return;
			}

			selectedMenu = input;
			Console.WriteLine("음료수 {0}(을)를 선택하셨습니다.", selectedMenu);

			PurchaseDrink();
		}

		private void PurchaseDrink()
		{
			Console.WriteLine("음료를 구매하려면 돈을 투입하세요: ");
			string input = Console.ReadLine();

			try
			{
				money = int.Parse(input);
				Console.WriteLine("{0}원을 투입하셨습니다.", money);
			}
			catch (FormatException)
			{
				Console.WriteLine("투입할 금액은 숫자로만 입력되어야 합니다!");
				return;
			}

			if (money - menu[selectedMenu] < 0)
			{
				Console.WriteLine("투입한 금액이 물건 금액보다 적습니다!");
				return;
			}
			else
			{
				money -= menu[selectedMenu];
				
				if (money > 0)
				{
					Console.WriteLine("거스름돈 {0}원을 배출합니다.", money);
					money = 0;
				}

				GiveDrink();
			}
		}

		private void GiveDrink()
		{
			Console.WriteLine("구매하신 음료수 {0}(을)를 배출합니다.", selectedMenu);
			selectedMenu = "";
		}
	}
}
