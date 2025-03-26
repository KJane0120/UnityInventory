# 프로젝트 이름

**UnityInventory**

## 📖 목차
1. [프로젝트 소개](#프로젝트-소개)
2. [팀소개](#팀소개)
3. [프로젝트 계기](#프로젝트-계기)
4. [주요기능](#주요기능)
5. [개발기간](#개발기간)
6. [기술스택](#기술스택)
7. [트러블슈팅](#트러블슈팅)
    
## 👨‍🏫 프로젝트 소개
내일배움캠프 Unity 7기 게임개발 심화 개인과제입니다.

## 팀소개
//Only Me

## 프로젝트 계기
Inventory의 유연한 구현을 목적으로 다양한 구현방법을 학습하기 위해 만들었습니다. 

## 💜 주요기능

**- 기능 1
메인메뉴UI**

초기화면으로, 플레이어의 레벨과 호칭, 닉네임등의 기본적인 정보가 표시됩니다. 

[실행전]
![image](https://github.com/user-attachments/assets/6ed744b6-236e-4494-8327-6c8c438aa7dd)

보유한 골드를 확인할 수 있고, 획득한 경험치에 따라 게이지바가 업데이트됩니다. 

[실행후]
![image](https://github.com/user-attachments/assets/e4b655c8-647e-4804-b582-8601a92d7ec3)


Status 버튼 클릭 시 상태UI창으로 이동합니다. 

Inventory 버튼 클릭 시 인벤토리UI창으로 이동합니다. 

**- 기능 2
상태UI**

플레이어의 스탯을 확인할 수 있습니다. 


![image](https://github.com/user-attachments/assets/d8c23ced-25ff-4e20-aa68-66c4685a42c3)

초기에는 기본 스탯이 표시되며, 이후 인벤토리에서 아이템을 장착할 경우 아이템 스탯이 플레이어의 스탯에 반영됩니다. 

![image](https://github.com/user-attachments/assets/94560a62-e49c-4a75-92db-075a187cd4d3)


**- 기능 3
인벤토리UI**
1. 슬롯 스크롤뷰
   
   인벤토리의 Vertical 스크롤이 가능합니다.

   이후 아이템이 추가적으로 추가되더라도 슬롯의 개수를 필터링해 전부 스크롤할 수 있습니다. 

3. 슬롯 동적 생성
   
   현재 보유한 아이템 개수에 따라 슬롯이 동적으로 생성됩니다.

4. 인벤토리 아이템 개수 표시

   인벤토리에 최대로 소지 가능한 개수와 현재 내가 보유한 아이템의 개수를 표시합니다.

5. 아이템 정보 슬롯 반영

   보유한 아이템의 정보를 각 슬롯에 할당합니다.

   슬롯의 이미지에 아이템의 아이콘이 표시됩니다.

6. 장착 가능

   ![image](https://github.com/user-attachments/assets/032cfffe-fd97-4aca-af97-bccee4940e4e)

   장착하고 싶은 아이템이 들어있는 슬롯을 클릭시,

   현재 장착중이라면 해제, 장착중이 아니라면 장착합니다.

   장착이 되면 장착이미지로 장착여부를 표시하고, 이후 아이템 스탯이 플레이어 상태에도 반영된 사항을 확인할 수 있습니다.
   

## ⏲️ 개발기간
- 25.03.24(월) ~ 25.03.26(수)

## 📚️ 기술스택

### ✔️ Language
C#

### ✔️ Version Control
Githup Desktop

### ✔️ IDE
Visual Studio

### ✔️ Framework
Unity Engine

## 트러블슈팅

1. 할당 착각 이슈

   ![image](https://github.com/user-attachments/assets/0df3fe56-9e59-4d58-80a6-eb7af17dac07)

   UISlot으로 선언한 slot에 프리팹을 할당할 경우 프리팹의 어떤 컴포넌트를 가져올지를 결정하는 것이지 프리팹 자체가 아닌 것은 아닌데, 
   프리팹을 할당하기 위해서는 무조건 Gameobject로만 가져와야 한다고 착각했다. 

   아마 이미지가 프리팹 이미지가 아닌 스크립트 이미지가 떠 착각한 것 같다. 

   그때문에 불필요한 코드를 추가했었지만, 피드백을 거치면서 좀 더 깔끔한 코드를 구현할 수 있었다. 

   [전]
   ```
   for (int i = 0; i < count; i++)
   {
       UISlot newSlot = Instantiate(slot.Prefab, content).GetComponent<UISlot>();
       UISlots.Add(newSlot);
   }
   ```
   [후]
   ```
   for (int i = 0; i < count; i++)
   {
       UISlot newSlot = Instantiate(slot, content);
       UISlots.Add(newSlot);
   }
   ```

2. 아이템 아이콘을 Image가 아닌 string으로 선언

   Resources 폴더를 생성하고 그 안에 원하는 아이템 아이콘을 추가한후, Image를 직접 할당하는 게 아닌 이미지의 경로를 참조하는 형식을 활용해보았다.

   새로운 시도다보니 미흡한 부분이 많았는데, 경로를 참조할 경우 이미지를 로드할 때 string으로 선언된 건 gameObject를 SetActive해줄 수 없어 따로 로드해주는 작업을 거쳐야 했다.

   ```
   /// <summary>
   /// 슬롯에 아이템 데이터를 추가합니다. 
   /// </summary>
   /// <param name="data"></param>
   public void SetItem(Item data)
   {
       item = data;

       if (item != null)
       {
           Sprite loadedIcon = Resources.Load<Sprite>(item.icon);
           if (loadedIcon != null)
           {
               icon.sprite = loadedIcon;
               icon.gameObject.SetActive(true);
           }
          else
           {
               Debug.Log("아이콘 경로를 찾을 수 없습니다.");
               icon.gameObject.SetActive(false);
           }
       }
       else
       {
           icon.gameObject.SetActive(false);
       }
   }
   ```

3. 참조 이슈

   아이템 아이콘 클릭시, 장착되어 아이템 스탯이 플레이어 스탯에 정상 반영되는 것까지 확인했지만, 장착여부를 표시하는 이미지의 On/Off가 제대로 동작하지 않는 버그가 있었다. 

   ```
   public Image equipCheck { get { return UIManager.Instance.UIInventory.slot.equipCheck; } }
   ```

   확인해보니, 프로퍼티로 잘못된 참조, 즉 각 슬롯이 아닌 원본 프리팹의 장착여부 표시 이미지를 참조하고 있었기 때문에 내 의도와는 다르게 원본 프리팹의 장착여부 표시 이미지가 On/Off되고 있었다.

   원래는 슬롯이 눌렸을 때 Character.cs에 있는 OnEquip()함수가 호출되고, 그 안에서 위 변수 선언을 해준 후 On/Off하는 코드도 같이 넣어줬는데,

   ```
    [SerializeField] private GameObject equipCheck;

    private void Start()
    {
        equipifClick.onClick.AddListener(Equip);
    }

    private void Equip()
    {
        GameManager.Instance.player.OnEquip(this);

        if (GameManager.Instance.player.IsEquip(this))
        {
            equipCheck.SetActive(true);
        }
        else equipCheck.SetActive(false);
    }
   ```

   피드백 후 UISlot 내부에서 위와 같이 각 클래스가 맡은 역할로만 수행하도록 수정작업을 거쳤다. 

   

   
