객체지향 설계를 하다보면 객체들 사이에서 다양한 처리를 할 경우가 많다.

예를 들어 한 객체의 상태가 바뀔 경우 다른 객체들에게 변경됐다고 알려주는 경우를 들 수 있다.

상태를 가지고 있는 주체 객체와 상태의 변경을 알아야 하는 관찰자 객체(Observer Object)가 존재하며

이들의 관계는 1:1이 될 수도 있고 1:N이 될 수가 있다.

서로의 정보를 넘기고 받는 과정에서 정보의 단위, 객체들의 규모, 각 객체들의 관계가 커지고 복잡할 수록 점점 구현하기 어려워지고 복잡성이 매우 증가할 것이다.

이러한 기능을 할 수 있도록 가이드라인을 제시해 주는 것이 바로 옵저버 패턴이다.

이러한 관계들의 실생활에서 찾아보면 우유배달업체와 고객들, 신문사와 정기구독자들, 인터넷 까페운영진과 회원들 등등 무수히 많은 케이스가 있다.