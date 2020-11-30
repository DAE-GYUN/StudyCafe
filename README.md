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

# �����͸� �ٸ������� �Ѱ� ������ �����ڸ� �̿��� ��� �Ѱܹ޾ƾ� �ϴ� ���ŷο��� ����

## ����
- �α��� �� ������ �����͸� �Ѱ� �ޱ� ���ؼ��� �����ڸ� ������ �����ؾ� �ϴ� �ߺ��ڵ尡 �������

## ����
- �ٸ������� ����� �����͸� ����ϱ� ���ؼ��� ������ �����͸� �Ѱ� �� �� �����ڸ� �̿��� �޾� ����ؾ���


## ���
- �α��� �� ������ �����͸� ��� ����� �� �ֵ��� �̱������� Ŭ������ ����
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
# ī�޶� ����� OpenCV ���̺귯���� ������ �� ���� ����

## ����
- ����� ���� ���� ���������� ī�޶� �����ϸ� ��ϵ��� ���� ����̽� ������ �߻��ϰ� ������ �� ����

## ����
- opencv ��ġ�� x64 �÷����� �⺻������ �����Ǿ��־� ���� ������ ��������

## ���
- ���������ڿ��� x64 �÷������� ������ �����ϴ� ������� ����ϴٰ� Nuget ��Ű������ AnyCPU �������� �ٿ�޾� �����
- ������ �ٲ� �� ������ �����ϳ� �÷��� ���̸� ��Ȯ�ϰ� ���������� ���� 