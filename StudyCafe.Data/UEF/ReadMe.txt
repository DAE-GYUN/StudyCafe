
1. 아래 코드를 실행하면 프레임워크가 생성됩니다.
Lovanpis.UsingEntityFramework.CodeGenerator.Generate(new StudyCafe.Data.KoreanStudyCafeEntities(), @"C:\Users\kccistc\Desktop\KDJ\Git_StudyCafe\StudyCafe.Data");            


2. 엔터티의 부분 클래스는 아래 경로에 위치하며, 한번 만들어진 파일은 덮어씌어지지 않습니다.
C:\Users\kccistc\Desktop\KDJ\Git_StudyCafe\StudyCafe.Data\UEF\Entities


3. Dao의 부분 클래스는 아래 경로에 위치하며, 한번 만들어진 파일은 덮어씌어지지 않습니다.
C:\Users\kccistc\Desktop\KDJ\Git_StudyCafe\StudyCafe.Data\UEF\Dao


4. 생성된 프레임워크의 대부분의 코드는 아래 경로에 위치하며, 이 파일은 프레임워크를 생성할 때 마다 다시 생성됩니다.
C:\Users\kccistc\Desktop\KDJ\Git_StudyCafe\StudyCafe.Data\UEF\GeneratedByMP.cs

5. C:\Users\kccistc\Desktop\KDJ\Git_StudyCafe\StudyCafe.Data\UEF\DbContextFactory.cs 정적 생성자에 연결문자열을 지정합니다.
public partial class DbContextFactory
{
    static DbContextFactory()
    {
        RawConnectionString = "data source=192.168.8.127;initial catalog=KoreanStudyCafe;user id=sa;password=3512;MultipleActiveResultSets=True;App=EntityFramework";
    }
}