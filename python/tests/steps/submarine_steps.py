from pytest_bdd import scenarios, given, when, then, parsers

from src.submarine import Submarine

scenarios("submarine.feature")


@given("a submarine", target_fixture="submarine")
def a_submarine() -> Submarine:
    return Submarine()


@when(parsers.cfparse('submarine receives command {command}'))
def submarine_receives_command(submarine: Submarine, command):
    submarine.execute_command(command)


@then(parsers.cfparse('submarine depth should be {value:d}'))
def submarine_depth_should_be(submarine: Submarine, value: int):
    assert submarine.depth() == value


@then(parsers.cfparse('submarine position should be {value:d}'))
def submarine_position_should_be(submarine: Submarine, value: int):
    assert submarine.position() == value


@then(parsers.cfparse('submarine aim should be {value:d}'))
def submarine_aim_should_be(submarine: Submarine, value: int):
    assert submarine.aim() == value


@then(parsers.cfparse('submarine final value should be {value:d}'))
def submarine_final_value_should_be(submarine: Submarine, value: str):
    assert submarine.position() * submarine.depth() == value
