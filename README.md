# 포트폴리오

+ 순서
   + 들어가기 전에
   + 다이렉트3D - 주사위 게임
      + 소개
      + 실행 및 조작법
      + 실행 영상
      + 제작 과정 중 문제와 해결 방법
      + 마침
   + 유니티 - 사냥꾼의 꿈
      + 소개
      + 조작법
      + 구현
        + 이동 및 시점
        + 공격
        + 적
      + 실행 영상
      + 진행 상황 및 문제점
## 들어가기 전에
저는 SBS게임아카데미 학원에서 유니티와 클라이언트(다이렉트3D)수업을 아래와 같이 수료했습니다.

클라이언트(다이렉트3D) : 22.09.14~12.26

유니티 : 22.07.17~01.15

유니티 수업에서는 처음 배우는 코딩에 익숙해지는 시간과 깃허브의 사용법 그리고 유니티 엔진의 기초적인 사용법에 대해 배울수 있었습니다.

클라이언트(다이렉트3D) 수업은 c,c++ 언어들을 순차적으로 배우고 나아가 API, 다이렉트3D까지 보다 전문적이고 어려운 코딩을 배웠습니다.

두 수업을 동시에 듣느라 유니티 포폴을 만드는데 차질이 좀 있었지만 보다 다양한 지식을 빠른 시간안에 쌓을수 있어 유익한 시간이었습니다.

우선 먼저 마무리 했던 다이렉트3D 부터 소개하고 미완성된 "유니티 - 사냥꾼의 꿈"은 나중에 소개하려 합니다.

감사합니다.
## 다이렉트3D - 주사위 게임
### 소개

![dice_game](https://user-images.githubusercontent.com/109446732/212500352-4ea5d733-ee92-496b-bb8c-d99b003948db.png)

"다이렉트3D - 주사위 게임" 은 3개월이라 아주 짧은 시간동안 가능한 남들에게 소개할수 있게끔 만들려고 한 게임입니다.

버텍스 버퍼로 크기를 정하고 인덱스 버퍼로 좌표를 찍어서 큐브를 만드는 과정은 앞으로 해야할 것들에 비하면 그나마 쉬운 과정이었습니다.

빌보드 는 y축 빌보드를 사용하였고 광원은 처음에 Point 타입을 적용하려다 실패하여 Directional 타입으로 전환해 성공 했습니다.

방향전환에서 제자리 회전과 회전으로 인한 방향전환 및 이동은 작업중 가장 어려운 부분이었습니다.
핵심은 행렬을 이해하고 D3DXMatrixMultiply 함수를 활용한 수많은 경험이 해결에 큰 도움이 되었습니다.

이후에 좀더 개선할수도 있지만 유니티 프로젝트로 넘어가기 위해 일단은 마무리 하였습니다.
### 실행 및 조작법

Direct3D 폴더의 play 폴더로 들어가시면 보이는 game.exe 파일이 실행 파일입니다.

기본적인 방향키 와 wasd 로 이동이 가능하며 넘버키 4856 으로 방향 전환이 가능합니다.
### 실행 영상

![D3D_play](https://user-images.githubusercontent.com/109446732/212500636-b931c40e-681d-4189-9cc4-957a8868e22e.gif)
### 제작 과정 중 문제와 해결법

기본적인 언어체계 c, c++, c# 을 포함해서 API, 다이렉트3D 까지 모든 부분이 난생 처음이라 거의 모든 부분에서 문제가 있었습니다.

그중에서 다이렉트3D 관련하여 몇가지만 언급하자면

> 큐브 생성후 뒷면이 투명하게 보이는 현상 - 이미지의 생성 순서를 뒷면에 맞춰서 재설정하여 해결했습니다.

> 큐브 방향 전환 - D3DXMatrixMultiply 함수를 활용한 이동 과 방향전환을 동시에 적용하는 부분은 지금도 어렵습니다. 그 당시에도 수백번이 넘는 실험이 있었고 동기의 조언 덕분에 겨우 해결했습니다.

> 광원 - 버텍스 버퍼의 들어갈 normal 값을 이해하고 적용하는 법을 배우는데 1주일을 소비했습니다. 주로 인터넷에서 관련 자료를 참고하거나 강사님께 normal 값의 역할에 대해 질문하였습니다.

> 빌보드 - y축 회전행렬은 11, 13, 31, 33번 행렬에 회전값이 들어간다는 부분을 찾는데 시간이 좀 걸렸지만 다른 문제들 보단 빠르게 해결했습니다.
### 마침

유니티와 비교하면 다이렉트3D는 확실히 어려웠습니다.

기본적인 모든것이 준비되어 있던 유니티와 다르게 다이렉트3D는 처음부터 하나하나 스스로 만들어야 했으니까요.

아직 미숙하고 배운 기간이 짧아 결과물 또한 만족스럽진 못하지만 게임 코딩을 배우려면 다이렉트3D는 필수로 배워야 한다는 강사님들의 조언에 따라 언젠가 시간이 된다면 좀더 공부할 생각입니다.
## 유니티 - 사냥꾼의 꿈
### 소개
![전체 맵](https://user-images.githubusercontent.com/109446732/230705667-2c889450-cd4e-4559-a292-5f3a39f47b1b.png)
![도시](https://user-images.githubusercontent.com/109446732/230705680-b781372c-ffcc-4e48-9275-5120228b1d19.png)

"유니티 - 사냥꾼의 꿈"은 "레드데드리뎀션2"의 영향을 받아 제작한 FPS 게임입니다.

아직 미완성된 상태로 움직임과 간단한 공격만 가능하지만 추후 동물들을 적으로 추가해 루팅하고 얻은 재료를 판매하여 자본을 모으는 게임으로 만들어갈 생각입니다.

그렇게 얻은 자본으로 무기를 구매하여 능력을 향상시키거나 엔딩을 위한 집 구매가 최종 목표입니다.

----

### 조작법

wasd 와 기본적인 방향키로 움직이며 마우스의 움직임에 따라 카메라가 회전합니다
공격은 마우스 왼쪽으로 일직선적인 공격, 오른쪽으로 슈루탄을 던집니다.

----

### 구현

![스크린 캡처_20230519_145400](https://github.com/nimonemo434/Hunter_project_V2/assets/109446732/f48e54db-92d4-4139-bba7-93d3af36000c)

#### < 이동 및 시점 >

Horizontal 과 Vertical를 GetAxis함수로 받아서 w, a, s, d 와 화살표를 이용한 움직임을 구현하고 jump를 활용하여 스페이스바 입력시 주어진 값(jumpPower)
을 y축 값에 더하여 떠오르게 만들었습니다.

이때 시간이 지날수록(Time.deltaTime) 캐릭터의 y축 값을 중력 값(gravity) 만큼 지속적으로 갑소 시켜서 중력을 따로 구현하였고
y축 값을 지면에 닿아있을때 마다 0으로 초기화 하여 떨어지는 속도가 너무 빨라지지 않도록 하였습니다.

rigidbody 사용시 자동적으로 중력 구현이 가능하지만 이번에는 좀더 가벼운 character controller를 활용해 보기로했습니다.

연속 점프 방지를 위해 새로운 조건 값(true,false)을 추가하고 점프를 하려면 지면(CollisionFlags.Below)과 닿아있고 점프값이 비활성화 되어있어야 한다는것을 추가합니다.

마우스의 입력값(Mouse X,Mouse Y)을 받아서 회전방향(vector3)을 결정하고 회전한 방향으로 물체가 회전하도록(transform.eulerAngles) 하였습니다.
이때 Mathf 클래스의 Clamp 함수를 사용하여 상하 회전의 제한을 두어 일정범위을 넘지 않도록 설정하였습니다.

게임 시작전에 카메라는 플레이어와 떨어져 있지만 플레이어 안에 빈 오브젝트를 생성하고 오브젝트의 좌표로 카메라가 이동하도록(transform.position = target.position) 하였습니다.

----

![스크린 캡처_20230519_145443](https://github.com/nimonemo434/Hunter_project_V2/assets/109446732/9d6f1f63-8015-47e7-9289-264fae7e3ac2)

#### < 공격 >

공격을 2가지 형태로 구현되어 있습니다.

먼저 던지는 형태 슈루탄 공격의 경우 충돌시(OnCollisionEnter)에도 제거(Destroy)되며 충돌 된 위치(transform.position)에 이펙트가 생성(Instantiate) 되게끔 하였습니다.

이펙트는 정해진 시간 값을 측정된 시간 값이 넘어갈 경우 삭제(Destroy) 되도록 설정 했습니다.

----

![스크린 캡처_20230519_151139](https://github.com/nimonemo434/Hunter_project_V2/assets/109446732/7763ddb3-6f14-4d21-9e64-dd97697b71ed)

#### < 적 >

----

### 제작 과정 중 문제와 해결법

데부분 유니티에 있는 기능들을 사용할줄 모르거나 있는줄 몰라서 생기는 문제들 이었습니다.
강사님께 조언을 구하거나 인터넷을 통해 해결할수 있었습니다.

> 시점 변환시 일정 값을 넘어가면 바닥을 내려다보는 현상(transform 컴포넌트의 특성으로 특정값을 넘어가면 자동으로 변환되면서 생기는 현상) - 마우스 회전값 변수에 입력 값을 미리 누적함으로써 해결했습니다.

### 진행 상황 및 문제점

현재 기본적인 움직임과 간단한 공격및 맵구현만 되어있는 상태입니다.

추후 동물들을 적으로 추가 및 애니메이션과 다양한 기능을 추가해보려 합니다.
