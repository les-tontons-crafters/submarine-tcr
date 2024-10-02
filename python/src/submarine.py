from src.submarine_interface import SubmarineInterface


class Submarine(SubmarineInterface):
    def execute_command(self, command: str) -> None:
        pass

    def aim(self) -> int:
        return 0

    def position(self) -> int:
        return 0

    def depth(self) -> int:
        return 0
