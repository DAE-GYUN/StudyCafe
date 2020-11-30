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

#

## 증상


## 원인


## 결과

---

```csharp
// before
private void btnGoBack_Click(object sender, EventArgs e)
{
    EmployeeSelectFunctionControl employeeSelectFunctionControl = 
        new EmployeeSelectFunctionControl();
    OnbtnCancelClicked(employeeSelectFunctionControl);
}

// after
private void btnGoBack_Click(object sender, EventArgs e)
{
    EmployeeSelectFunctionControl employeeSelectFunctionControl = 
        new EmployeeSelectFunctionControl(currentEmployeeInHere);
    OnbtnCancelClicked(employeeSelectFunctionControl);
}
```