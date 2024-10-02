from abc import ABC, abstractmethod


class SubmarineInterface(ABC):
    @abstractmethod
    def execute_command(self, command: str) -> None:
        pass

    @abstractmethod
    def aim(self)-> int:
        pass

    @abstractmethod
    def position(self)-> int:
        pass

    @abstractmethod
    def depth(self)-> int:
        pass
