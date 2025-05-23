# SpartaDungeon
제출용 

## 1. 개요
스파르타 던전 개인 과제 제출용 레포지토리

---
## 2. 유니티 버전
- **Unity 2022.3.17f1**


## 3. 폴더 구조
```
Assets/
  ├── InputActions/             # 입력 시스템 관련 설정
  ├── Materials/                # 스카이박스
  ├── Prefabs/                  # 재사용 가능한 프리팹(맵 오브젝트, 장착 오브젝트, 아이템 슬롯 UI, 아이템)
  ├── Scenes/                   # 게임 씬
  ├── Externals/                # 외부 에셋
  ├── Scripts/                  # C# 스크립트
  │   ├── Player/               # 캐릭터 매니저, 플레이어, 플레이어 컨트롤러, 플레이어 컨디션, 상호작용, 장비
  │   ├── Objects/              # 맵 오브젝트(벽, 바닥, 점프대 등), 함정
  │   ├── Item/                 # 아이템 오브젝트, 장착
  │   ├── ScriptableObject/     # 스크립터블 오브젝트로 만든 아이템들
  │   ├── Interface/            # 인터페이스
  │   └── UI/                   # UI 스크립트, 
  └── TextMesh Pro/             # 텍스트 렌더링용 에셋
```

## 4. 주요 기능 및 시스템

### 4.1. 캐릭터 매니저 및 플레이어 오브젝트 관리
- `CharacterManager`: 플레이어 싱글톤 인스턴스 관리
- `Player`: 플레이어 엔티티의 핵심 컴포넌트 관리
- `PlayerController`: 캐릭터 이동 및 카메라 제어
- `PlayerCondition`: 플레이어 상태 관리
- `Interaction`: 오브젝트 상호작용 시스템
- `Equipment`: 장비 장착 시스템

### 4.2. Object 스크립트
- `MovingPlatform`, `JumpPad`, `LaserTrap` 등으로 맵 제작에 필요한 여러 오브젝트 구현, laserTrap의 경우 플레이어 접촉을 처음에는 Raycast를 통해 감지하려고 했으나 해당 역할을 laser로 옮김
- `Laser` 오브젝트로 플레이어가 접촉 시 체력이 닳는 효과 구현

### 4.3. UI 시스템
- `Condition` 게임 내 상태 값(체력/스태미나) 관리 및 UI 연동
- `UICondition` 플레이어 상태 UI 연동 시스템
- `DamageIndicator` 피격 시 화면 적색 효과
- `ItemSlot` 인벤토리 개별 슬롯 관리
- `UIInventory` 인벤토리 관리 시스템 ( 장착하는 과정에 오류 있음)

### 4.4. Item 시스템
- `Equip` EquipTool에 상속시킬 클래스, 인풋 시스템을 받아 던지기 기능 실행
- `EquipTool` 장착한 아이템 던지기 기능 포함
- `ItemObject` 월드에 배치된 아이템 오브젝트(드롭된 아이템, 상호작용 가능)
- `ThrowTool` 던진 오브젝트를 맵 오브젝트에 고정하여 플레이어가 밟을 수 있는 발판 기능 제공 (구현 실패)

### 4.5. ScriptableObject
- `ItemData` 


## 5. Project Timeline
- **기획 및 설계:** 2024.05.08 ~ 2024.05.08
- **필수 기능 구현:** 2024.05.09 ~ 2024.05.12
- **도전 기능 구현 및 디버깅:** 2024.05.13 ~ 2024.05.15


