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
      + 제작중
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
### 제작중
![city](https://user-images.githubusercontent.com/109446732/212501407-fc74dd8b-eee8-4325-8238-b60ca5fc6e05.png)
![world](https://user-images.githubusercontent.com/109446732/212501408-d0ef0563-6d9d-4e0e-92c0-731ae7471a35.png)
