using System;
using System.Collections.Generic;
using System.Text;

using CSharp;

namespace CSharp._20220227
{
	class String
	{
		static void Main_20220227_1(string[] args)
		{
			string str1 = "안녕하세요";
			string str2 = "안녕하세요";
			Console.WriteLine("str1 '{0}'의 길이는 {1}글자 입니다.", str1, str1.Length);
			Console.WriteLine("str2 '{0}'의 길이는 {1}글자 입니다.", str2, str2.Length);
			Console.WriteLine("두 문자열은 {0}", str1 == str2 ? "같습니다." : "다릅니다.");
			Console.WriteLine("두 문자열은 {0}\n", str1.Equals(str2) ? "같습니다." : "다릅니다."); // 이게 더 안정적
			
			Console.WriteLine(string.Compare("너구리", "사슴")); // 사전에 등록된 순서(ABC...가나다...)를 기준으로 비교 (A가 더 앞설 경우 1, B가 더 앞설 경우 -1)
			Console.WriteLine(str1[2]); // 배열처럼 사용 가능
			Console.WriteLine(str1.IndexOf("하")); // 문자의 위치 찾기 (없는 글자: -1)
			Console.WriteLine("");

			string str3 = "최근 국제유가(두바이유)는 우크라이나 사태 영향으로 배럴당 100달러에 육박하며 고공행진을 이어가고 있다. 27일 한국석유공사 유가 정보 사이트 오피넷에 따르면 수입 원유 기준이 되는 두바이유 가격은 2월 넷째 주 평균 95.0달러로 집계됐다.";
			Duplicate.PrintArray(str3.Split(" ")); // 특정 규칙을 가진 문자열 자르기
			Console.WriteLine("");

			Console.WriteLine(str1.Substring(2)); // 문자열 자르기 (3번째 글자부터 끝까지 가져오기)
			Console.WriteLine(str3.Substring(5, 15)); // 문자열 자르기 (6번째 글자부터 15글자 가져오기)
			Console.WriteLine("");

			string str4 = "안녕하세요" + " 반가워요";
			Console.WriteLine(str4);
			string str5 = "안녕하세요 ";
			Console.WriteLine(string.Concat(str5, "반가워요"));
			Console.WriteLine("");

			Console.WriteLine(str3.Replace(" ", "?"));
			Console.WriteLine("");

			Console.WriteLine("str5에 '안녕'이 존재{0}", str5.Contains("안녕") ? "합니다." : "하지 않습니다.");
			Console.WriteLine("");

			string str6 = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nullam non congue nulla. Nullam varius convallis mauris eget mattis.";
			Console.WriteLine("str6를 대문자로 교체: {0}", str6.ToUpper());
			Console.WriteLine("str6를 소문자로 교체: {0}", str6.ToLower());

			string search = "it";
			int index = str6.IndexOf(search);
			string subs = str6.Substring(index, search.Length).ToUpper();
			Console.WriteLine("str6에서 '{0}'를 대문자로 교체: {1}", search, str6.Replace(search, subs));
		}
	}
}
