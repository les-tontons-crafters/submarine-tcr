from src.submarine_interface import SubmarineInterface


class Submarine(SubmarineInterface):
    def execute_command(self, command: str) -> None:
        raise NotImplementedError("Not Implemented")

    def aim(self) -> int:
        raise NotImplementedError("Not Implemented")

    def position(self) -> int:
        raise NotImplementedError("Not Implemented")

    def depth(self) -> int:
        raise NotImplementedError("Not Implemented")
