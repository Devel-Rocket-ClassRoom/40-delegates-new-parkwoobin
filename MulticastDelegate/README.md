# 멀티캐스트 대리자

문자열 처리 파이프라인을 멀티캐스트 대리자로 구현하시오.

**요구사항**:

1. `Action<string>` 대리자를 사용하여 문자열 처리 파이프라인을 구성하시오

2. 다음 처리 메서드를 구현하시오
   - `PrintOriginal`: 원본 문자열 출력 (형식: `원본: {문자열}`)
   - `PrintUpper`: 대문자로 변환하여 출력 (형식: `대문자: {문자열}`)
   - `PrintLower`: 소문자로 변환하여 출력 (형식: `소문자: {문자열}`)
   - `PrintLength`: 문자열 길이 출력 (형식: `길이: {숫자}`)

3. 파이프라인에 메서드를 순차적으로 추가하며 테스트하시오
   - 단계 1: `PrintOriginal`만 등록
   - 단계 2: `PrintUpper` 추가
   - 단계 3: `PrintLower`, `PrintLength` 추가
   - 단계 4: `PrintUpper` 제거

4. 테스트 문자열: "Hello World"

## 예상 실행 결과

```
=== 문자열 처리 파이프라인 ===

--- 단계 1: 원본 출력만 ---
원본: Hello World

--- 단계 2: 대문자 추가 ---
원본: Hello World
대문자: HELLO WORLD

--- 단계 3: 소문자, 길이 추가 ---
원본: Hello World
대문자: HELLO WORLD
소문자: hello world
길이: 11

--- 단계 4: 대문자 제거 ---
원본: Hello World
소문자: hello world
길이: 11
```
