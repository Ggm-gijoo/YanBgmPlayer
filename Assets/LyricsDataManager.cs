using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LyricsDataManager : MonoBehaviour
{
    Dictionary<int, string[]> lyricsData;

    private void Awake()
    {
        lyricsData = new Dictionary<int, string[]>();
        GenData();
    }

    public void GenData()
    {
        lyricsData.Add(0, new string[] 
        {
            "<i>\"하루에 총 800시간씩 잔다.\"",
            "<i>\"하루에 총 800시간씩 잔다.\"",
            "<i>\"하루에 총 800시간씩 잔다.\"",
            "<i>\"하루에 총 800시간씩 잔다.\"",
            "<i>\"그리고 나서 우유를 1리터 마시고, ",
            "<i>\"그리고 나서 우유를 1리터 마시고, ",
            "<i>\"그리고 나서 우유를 1리터 마시고, 놀러 나가기 전 몸을 푼다.\"",
            "<i>\"그리고 나서 우유를 1리터 마시고, 놀러 나가기 전 몸을 푼다.\"",
            "<i><size=90%>\"먹는 것도, ",
            "<i><size=90%>\"먹는 것도, 쓰는 것도, ",
            "<i><size=90%>\"먹는 것도, 쓰는 것도, 방아쇠를 당기는 것도 모두 오른손으로만 한다.\"",
            "<i><size=90%>\"먹는 것도, 쓰는 것도, 방아쇠를 당기는 것도 모두 오른손으로만 한다.\"",
            "이제 남은 한 가지는 명령을 잘 따르도록 애쓰는 것뿐",
            "이제 남은 한 가지는 명령을 잘 따르도록 애쓰는 것뿐",
            "이제 남은 한 가지는 명령을 잘 따르도록 애쓰는 것뿐",
            "이제 남은 한 가지는 명령을 잘 따르도록 애쓰는 것뿐",
            "정신을 차리면 너는 어느새 책상에 묶여",
            "정신을 차리면 너는 어느새 책상에 묶여",
            "정신을 차리면 너는 어느새 책상에 묶여",
            "정신을 차리면 너는 어느새 책상에 묶여",
            "<size=85%>너의 꿈은 바닥에 널브러지고 눈은 시험지에 고정한 채로 명에 따르겠지",
            "<size=85%>너의 꿈은 바닥에 널브러지고 눈은 시험지에 고정한 채로 명에 따르겠지",
            "<size=85%>너의 꿈은 바닥에 널브러지고 눈은 시험지에 고정한 채로 명에 따르겠지",
            "<size=85%>너의 꿈은 바닥에 널브러지고 눈은 시험지에 고정한 채로 명에 따르겠지",
            "<i>\"<size=90%>30분 뒤에 신랑이나 신부를 찾는다, 머리카락이 흑갈색이면 더 좋다.\"",
            "<i>\"<size=90%>30분 뒤에 신랑이나 신부를 찾는다, 머리카락이 흑갈색이면 더 좋다.\"",
            "<i>\"<size=90%>30분 뒤에 신랑이나 신부를 찾는다, 머리카락이 흑갈색이면 더 좋다.\"",
            "<i>\"<size=90%>30분 뒤에 신랑이나 신부를 찾는다, 머리카락이 흑갈색이면 더 좋다.\"",
            "<i>\"<size=90%>90시간 뒤에 그의 속을 쏟아낸다, 너의 방을 그림같이 칠한다.\"",
            "<i>\"<size=90%>90시간 뒤에 그의 속을 쏟아낸다, 너의 방을 그림같이 칠한다.\"",
            "<i>\"<size=90%>90시간 뒤에 그의 속을 쏟아낸다, 너의 방을 그림같이 칠한다.\"",
            "<i>\"<size=90%>90시간 뒤에 그의 속을 쏟아낸다, 너의 방을 그림같이 칠한다.\""
        });

        lyricsData.Add(1, new string[]
        {
            "이제 또 다른 복수극을 벌일 시간",
            "이제 또 다른 복수극을 벌일 시간",
            "이제 또 다른 복수극을 벌일 시간",
            "이제 또 다른 복수극을 벌일 시간",
            "이제 또 다른 복수극을 벌일 시간",
            "이제 또 다른 복수극을 벌일 시간",
            "이제 또 다른 복수극을 벌일 시간",
            "책장을 뒤져가며 미리 쓰인 나의 인격을 골라낼 때",
            "책장을 뒤져가며 미리 쓰인 나의 인격을 골라낼 때",
            "책장을 뒤져가며 미리 쓰인 나의 인격을 골라낼 때",
            "책장을 뒤져가며 미리 쓰인 나의 인격을 골라낼 때",
            "책장을 뒤져가며 미리 쓰인 나의 인격을 골라낼 때",
            "책장을 뒤져가며 미리 쓰인 나의 인격을 골라낼 때",
            "책장을 뒤져가며 미리 쓰인 나의 인격을 골라낼 때",
            "도시의 아이들이 보는 것은",
            "도시의 아이들이 보는 것은",
            "도시의 아이들이 보는 것은",
            "도시의 아이들이 보는 것은",
            "도시의 아이들이 보는 것은",
            "도시의 아이들이 보는 것은",
            "도시의 아이들이 보는 것은",
            "흐린 시궁창 속 하늘에 비친 네온 별빛뿐",
            "흐린 시궁창 속 하늘에 비친 네온 별빛뿐",
            "흐린 시궁창 속 하늘에 비친 네온 별빛뿐",
            "흐린 시궁창 속 하늘에 비친 네온 별빛뿐",
            "<size=90%>도시의 밤에 그렇게나 간절히 속하고 싶어하는 이유는 묻지 말아요",
            "<size=90%>도시의 밤에 그렇게나 간절히 속하고 싶어하는 이유는 묻지 말아요",
            "<size=90%>도시의 밤에 그렇게나 간절히 속하고 싶어하는 이유는 묻지 말아요",
            "<size=90%>도시의 밤에 그렇게나 간절히 속하고 싶어하는 이유는 묻지 말아요",
            "<size=90%>도시의 밤에 그렇게나 간절히 속하고 싶어하는 이유는 묻지 말아요",
            "<size=90%>도시의 밤에 그렇게나 간절히 속하고 싶어하는 이유는 묻지 말아요",
            "<size=90%>도시의 밤에 그렇게나 간절히 속하고 싶어하는 이유는 묻지 말아요"
        });

        lyricsData.Add(2, new string[]
        {
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "<i>\"400,000미터 앞에서 오른쪽으로 꺾는다.\"",
            "<i>\"400,000미터 앞에서 오른쪽으로 꺾는다.\"",
            "<i>\"400,000미터 앞에서 오른쪽으로 꺾는다.\"",
            "<i>\"400,000미터 앞에서 오른쪽으로 꺾는다.\"",
            "<i>\"400,000미터 앞에서 오른쪽으로 꺾는다.\"",
            "<i>\"400,000미터 앞에서 오른쪽으로 꺾는다.\"",
            "<i>\"칼을 집어 하는 일 없는 낯익은 자를 찌른다.\"",
            "<i>\"칼을 집어 하는 일 없는 낯익은 자를 찌른다.\"",
            "<i>\"칼을 집어 하는 일 없는 낯익은 자를 찌른다.\"",
            "<i>\"칼을 집어 하는 일 없는 낯익은 자를 찌른다.\"",
            "<size=90%>사랑이나 커피의 씁쓸함 따위를 알기 전에 싸우는 법부터 익힌 나는",
            "<size=90%>사랑이나 커피의 씁쓸함 따위를 알기 전에 싸우는 법부터 익힌 나는",
            "<size=90%>사랑이나 커피의 씁쓸함 따위를 알기 전에 싸우는 법부터 익힌 나는",
            "<size=90%>사랑이나 커피의 씁쓸함 따위를 알기 전에 싸우는 법부터 익힌 나는",
            "날이 선 가위로 실을 싹둑 잘라 자유의 몸이 되었지만",
            "날이 선 가위로 실을 싹둑 잘라 자유의 몸이 되었지만",
            "날이 선 가위로 실을 싹둑 잘라 자유의 몸이 되었지만",
            "날이 선 가위로 실을 싹둑 잘라 자유의 몸이 되었지만",
            "<size=90%>내가 했던 모든 선택이 남의 의지에 따른 것이란 걸 알고 말았죠",
            "<size=90%>내가 했던 모든 선택이 남의 의지에 따른 것이란 걸 알고 말았죠",
            "<size=90%>내가 했던 모든 선택이 남의 의지에 따른 것이란 걸 알고 말았죠",
            "<size=90%>내가 했던 모든 선택이 남의 의지에 따른 것이란 걸 알고 말았죠",
            "어릴 적 우리는 9mm 구경 공갈 젖꼭지를 빨며",
            "어릴 적 우리는 9mm 구경 공갈 젖꼭지를 빨며",
            "어릴 적 우리는 9mm 구경 공갈 젖꼭지를 빨며",
            "어릴 적 우리는 9mm 구경 공갈 젖꼭지를 빨며",
            "<size=90%>우리에게 확장 말고는 아무런 목적이 없다는 사실을 삼켰고",
            "<size=90%>우리에게 확장 말고는 아무런 목적이 없다는 사실을 삼켰고",
            "<size=90%>우리에게 확장 말고는 아무런 목적이 없다는 사실을 삼켰고",
            "<size=90%>우리에게 확장 말고는 아무런 목적이 없다는 사실을 삼켰고",
            "살아남기 위해 타오르던 내 의지가 역효과를 낳으며",
            "살아남기 위해 타오르던 내 의지가 역효과를 낳으며",
            "살아남기 위해 타오르던 내 의지가 역효과를 낳으며",
            "살아남기 위해 타오르던 내 의지가 역효과를 낳으며",
            "<size=90%>지금 나는 내가 쓸모없다고 여겼던 사람이 되는 데 안주해야 하네요",
            "<size=90%>지금 나는 내가 쓸모없다고 여겼던 사람이 되는 데 안주해야 하네요",
            "<size=90%>지금 나는 내가 쓸모없다고 여겼던 사람이 되는 데 안주해야 하네요",
            "<size=90%>지금 나는 내가 쓸모없다고 여겼던 사람이 되는 데 안주해야 하네요"
        });
        lyricsData.Add(3, new string[]
        {
            "도시의 리본을 따라가면",
            "도시의 리본을 따라가면",
            "도시의 리본을 따라가면",
            "도시의 리본을 따라가면",
            "끝에는 아무도 귀 기울이지 않는 심장이",
            "끝에는 아무도 귀 기울이지 않는 심장이",
            "끝에는 아무도 귀 기울이지 않는 심장이",
            "끝에는 아무도 귀 기울이지 않는 심장이",
            "내 마음이 찢어지고 또 상처입고 나서야",
            "내 마음이 찢어지고 또 상처입고 나서야",
            "내 마음이 찢어지고 또 상처입고 나서야",
            "내 마음이 찢어지고 또 상처입고 나서야",
            "고통이 끝나지 않는 이유가 내게 있다는 걸 알고 말겠죠",
            "고통이 끝나지 않는 이유가 내게 있다는 걸 알고 말겠죠",
            "고통이 끝나지 않는 이유가 내게 있다는 걸 알고 말겠죠",
            "고통이 끝나지 않는 이유가 내게 있다는 걸 알고 말겠죠"
        });
        lyricsData.Add(4, new string[]
        {
            "이제 또 다른 복수극을 벌일 시간",
            "이제 또 다른 복수극을 벌일 시간",
            "이제 또 다른 복수극을 벌일 시간",
            "이제 또 다른 복수극을 벌일 시간",
            "이제 또 다른 복수극을 벌일 시간",
            "이제 또 다른 복수극을 벌일 시간",
            "이제 또 다른 복수극을 벌일 시간",
            "책장을 뒤져가며 미리 쓰인 나의 인격을 골라낼 때",
            "책장을 뒤져가며 미리 쓰인 나의 인격을 골라낼 때",
            "책장을 뒤져가며 미리 쓰인 나의 인격을 골라낼 때",
            "책장을 뒤져가며 미리 쓰인 나의 인격을 골라낼 때",
            "책장을 뒤져가며 미리 쓰인 나의 인격을 골라낼 때",
            "책장을 뒤져가며 미리 쓰인 나의 인격을 골라낼 때",
            "책장을 뒤져가며 미리 쓰인 나의 인격을 골라낼 때",
            "도시의 아이들이 보는 것은",
            "도시의 아이들이 보는 것은",
            "도시의 아이들이 보는 것은",
            "도시의 아이들이 보는 것은",
            "도시의 아이들이 보는 것은",
            "도시의 아이들이 보는 것은",
            "도시의 아이들이 보는 것은",
            "흐린 시궁창 속 하늘에 비친 네온 별빛뿐",
            "흐린 시궁창 속 하늘에 비친 네온 별빛뿐",
            "흐린 시궁창 속 하늘에 비친 네온 별빛뿐",
            "흐린 시궁창 속 하늘에 비친 네온 별빛뿐",
            "<size=90%>도시의 밤에 그렇게나 간절히 속하고 싶어하는 이유는 묻지 말아요",
            "<size=90%>도시의 밤에 그렇게나 간절히 속하고 싶어하는 이유는 묻지 말아요",
            "<size=90%>도시의 밤에 그렇게나 간절히 속하고 싶어하는 이유는 묻지 말아요",
            "<size=90%>도시의 밤에 그렇게나 간절히 속하고 싶어하는 이유는 묻지 말아요",
            "<size=90%>도시의 밤에 그렇게나 간절히 속하고 싶어하는 이유는 묻지 말아요",
            "<size=90%>도시의 밤에 그렇게나 간절히 속하고 싶어하는 이유는 묻지 말아요",
            "<size=90%>도시의 밤에 그렇게나 간절히 속하고 싶어하는 이유는 묻지 말아요"
        });
        lyricsData.Add(5, new string[]
        {
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "",
            "<i>\"<size=110%><color=#40D0FF>e</color></size> 를 끝까지 읊기 전까지, 집에 들어가지 않는다.\"",
            "<i>\"<size=110%><color=#40D0FF>e</color></size> 를 끝까지 읊기 전까지, 집에 들어가지 않는다.\"",
            "<i>\"<size=110%><color=#40D0FF>e</color></size> 를 끝까지 읊기 전까지, 집에 들어가지 않는다.\"",
            "<i>\"<size=110%><color=#40D0FF>e</color></size> 를 끝까지 읊기 전까지, 집에 들어가지 않는다.\"",
            "<i>\"<size=110%><color=#40D0FF>e</color></size> 를 끝까지 읊기 전까지, 집에 들어가지 않는다.\"",
            "<i>\"<size=110%><color=#40D0FF>e</color></size> 를 끝까지 읊기 전까지, 집에 들어가지 않는다.\"",
            "<i>2.71",
            "<i>2.71",
            "<i>8281",
            "<i>8281",
            "<i>8284",
            "<i>8284",
            "<i>5904",
            "<i>5904",
            "<i>5235",
            "<i>5235",
            "<i>3602",
            "<i>3602",
            "<i>8747",
            "<i>8747",
            "<i>1352",
            "<i>1352",
            "<i>6624",
            "<i>6624",
            "<i>9775",
            "<i>9775",
            "<i>7247",
            "<i>7247",
            "<i>0936",
            "<i>0936",
            "<i>9995",
            "<i>9995",
            "<i>9574",
            "<i>9574",
            "<i>9669",
            "<i>9669",
            "<i>6762",
            "<i>6762"
        });
    }

    public string GetLyrics(int id, int talkIndex)
    {
        if (talkIndex == lyricsData[id].Length) return null;
        else return lyricsData[id][talkIndex];
    }
}
