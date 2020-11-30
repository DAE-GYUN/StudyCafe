# StudyCafe : 키오스크 프로그램

# 개요

- 키오스크 기능 중 일부를 C# .NET Framework 및 EntityFramework를 이용해 구현하였다.

# 개발 기간

- 2020년 11월 23일 ~ 2020년 11월 29일

# 기능 목록

## 고객용 프로그램

## 관리자용 프로그램


# 관리 항목

### 1. 고객 정보
# 사용 기술

## 언어

- C# 8.0

## 프레임워크

- .Net FrameWork 4.8
- EntityFrameWork 6.2
- Winform

## 데이터베이스

* MSSQL Server 2019

## 기타 개발환경

- Windows 10
- Microsoft Visual Studio Community 2019 v16.8
- Microsoft SQL Server Management Studio v18.6

# 데이터베이스 스키마

# 순서도

# Point of Interest

# 데이터를 다른폼에서 넘겨 받을때 생성자를 이용해 계속 넘겨받아야 하는 번거로움이 존재

## 증상
- 로그인 한 유저의 데이터를 넘겨 받기 위해서는 생성자를 폼마다 생성해야 하는 중복코드가 만들어짐

## 원인
- 다른폼에서 사용한 데이터를 사용하기 위해서는 생성한 데이터를 넘겨 준 후 생성자를 이용해 받아 사용해야함


## 결과
- 로그인 한 유저의 데이터를 계속 사용할 수 있도록 싱글톤으로 클래스를 생성
---

```csharp
#region singleton
    private Credential()
    {
    }

    private static Credential _instance;

    public static Credential Instance
    {
        get
        {
            if (_instance == null)
                _instance = new Credential();

            return _instance;
        }
    }
#endregion

    public string PhoneNumber
    {
        get
        {
            return User.PhoneNumber;
        }
    }

    public User User { get; set; }
```
---
# 카메라 실행시 OpenCV 라이브러리를 실행할 수 없는 문제

## 증상
- 빌드는 오류 없이 가능하지만 카메라를 실행하면 등록되지 않은 디바이스 오류가 발생하고 실행할 수 없음

## 원인
- opencv 설치시 x64 플랫폼이 기본값으로 설정되어있어 정상 실행이 되지않음

## 결과
- 구성관리자에서 x64 플랫폼으로 수정후 실행하는 방법으로 사용하다가 Nuget 패키지에서 AnyCPU 버전으로 다운받아 사용함
- 버전을 바꾼 후 실행은 가능하나 플랫폼 차이를 정확하게 이해하지는 못함 