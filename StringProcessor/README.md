# 문자열 가공기

문자열을 받아 문자열을 반환하는 대리자를 사용하여 문자열 가공 프로그램을 작성하시오.

**요구사항:**

1. `StringProcessor`라는 이름의 대리자를 선언하시오
   - 매개변수: `string` 1개
   - 반환 타입: `string`

2. 다음 문자열 가공 메서드를 구현하시오
   - `ToUpperCase(string s)` → 대문자로 변환
   - `ToLowerCase(string s)` → 소문자로 변환
   - `AddBrackets(string s)` → `"["` + s + `"]"` 형태로 괄호 추가
   - `Reverse(string s)` → 문자열을 뒤집기 (char 배열 활용)

3. `ProcessAndPrint(string input, StringProcessor processor)` 메서드를 구현하시오
   - 대리자를 매개변수로 받아 실행하고 결과를 출력함

4. "Hello World"를 각 가공 메서드로 처리하시오

## 예상 실행 결과

```
=== 문자열 가공기 ===

원본: Hello World

[대문자 변환]
결과: HELLO WORLD

[소문자 변환]
결과: hello world

[괄호 추가]
결과: [Hello World]

[문자열 뒤집기]
결과: dlroW olleH
```
