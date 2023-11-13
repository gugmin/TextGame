# Text Game 개인 프로젝트


</br>

## 팀원: 김국민

> 콘솔로 개발한 TextGame 게임 프로젝트 입니다.  
> 개인 프로젝트이며, 배웠던 내용의 연장선으로 개발한 내용입니다.  
> 구현된 내용은 다음과 같습니다.

</br>

## 주요 기능
* 상태창
* 인벤토리
* 상점(미완)

* 게임 시작 화면
    * 간단한 애니메이션
    * 이름 적기
    * 직업선택

* 게임 진행
    * 시작 씬에서 '0' 을 누른다.

    ![GameStartScene](TextGame3/Images/1-1.png)
    * 본인의 이름(아이디)을 적는다.

     ![name](TextGame3/Images/1-2.png)
    * 원하는 직업을 선택한다.

     ![Job](TextGame3/Images/1-3.png)

    * 메인화면 진입 1. 상태보기, 2. 인벤토리, 3. 상점

     ![GameMainScene](TextGame3/Images/1-4.png)

    1). 상태보기 : 자신의 현재 스탯을 볼 수 있다.

     ![Stats](TextGame3/Images/1-5.png)

    2). 인벤토리 : 자신이 가지고 있는 아이템을 볼 수 있고, 장착 및 해제가 가능하다. 

     ![Inventory-1](TextGame3/Images/1-6.png)

     ![Inventory-2](TextGame3/Images/1-7.png)

     * 아이템 장착 후 상태 창을 들어가면 스텟이 반영 된걸 확인할 수 있다. 

     ![Inventory-3](TextGame3/Images/1-10.png)


    3). 상점 : 상점 리스트의 아이템 중 원하는 물건을 구매 할 수 있다.

     ![Shop-1](TextGame3/Images/1-8.png)

     * 아이템 구매 후 해당 아이템의 가격이 소지금에서 차감된 걸 확인할 수 있다.

     ![Shop-2](TextGame3/Images/1-10.png)

     * 아이템 구매 후 인벤토리를 들어가면 아이템이 추가 된걸 확인할 수 있다.

     ![Shop-3](TextGame3/Images/1-9.png)




##  기술 스택

![C#](https://img.shields.io/badge/-C%23-%7ED321?logo=Csharp&style=flat)

## 구현 기능

* 시작 애니메이션
* 상태창
* 캐릭터
* 이름 
* 직업
* 직업에 따른 스텟
* 소지금
* 인벤토리
* 상점
* 아이템
* 아이템 장착 및 해제 구현
* 아이템 구매 기능



## 프로젝트 시 일어난 문제와 해결  

### 프로젝트

__문제__:  
 
장착 및 해제 구현

*구현하기로 한 내용 : 장착 관리 창을 만들고, 원하는 무기의 번호를 입력하면 장착 및 해제가 가능하게 만든다.

*문제가 발생한 상황 : 게임시작시 아무것도 장착하지 않은 상태에서 아이템 장착을 연달아 했을때,
이전 아이템이 로그에 남아있어 장착이 되어 있는 아이템도 장착해제가 안됨.

*문제 해결을 위해 노력한 것 : 다른 동기 님께 조언을 구하고, 스스로 문제 해결을 위해 많은 고민을 했음.

__결과__:  

 장착 및 해제에 사용된 선택한 아이템과 착용중인 아이템을 비교하던 구문에 허점을 발견해 냈음.
해결방안 : 장착 및 해제 에 쓰인 if문의 조건을 더 세밀하게 조정해서 문제를 해결함.


## 해결하지 못한 문제

__문제__:  
 
 상점 아이템 구매

*구현하기로 한 내용 : 상점에 들어가서 원하는 아이템의 번호를 입력할 시 아이템을 구매 할 수 있게 만든다.

문제가 발생한 상황 : 아이템을 구매해서 인벤토리에 넣는거 까지는 구현이 됬는데, 한번 구매한 아이템이 중복으로
구매 되고 그 아이템은 인벤토리에 몇 개가 들어 있던지, 한번에 장착 및 해제가 된다. 그리고 실제 스텟 적용은 한개만
이루어 진다.

*문제 해결을 위해 노력한 것 : 시간에 치여 아직 건드리지 못한부분이다.

## 프로젝트 소감


<br/>
___김국민___  
처음으로 제대로? 만들어본 콘솔text게임 이고, 그렇기 때문에 더 잘만들고 싶었지만 마감에 치여 마무리한게 아쉽게만 느껴진다.
<br/>
