# StudyCafe : Ű����ũ ���α׷�

# ����

- Ű����ũ ��� �� �Ϻθ� C# .NET Framework �� EntityFramework�� �̿��� �����Ͽ���.

# ���� �Ⱓ

- 2020�� 11�� 23�� ~ 2020�� 11�� 29��

# ��� ���

## ���� ���α׷�

## �����ڿ� ���α׷�


# ���� �׸�

### 1. �� ����
# ��� ���

## ���

- C# 8.0

## �����ӿ�ũ

- .Net FrameWork 4.8
- EntityFrameWork 6.2
- Winform

## �����ͺ��̽�

* MSSQL Server 2019

## ��Ÿ ����ȯ��

- Windows 10
- Microsoft Visual Studio Community 2019 v16.8
- Microsoft SQL Server Management Studio v18.6

# �����ͺ��̽� ��Ű��

# ������

# Point of Interest

#

## ����


## ����


## ���

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