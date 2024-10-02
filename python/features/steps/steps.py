from behave import *
from behave.runner import Context

from src.submarine import Submarine


@given("a submarine")
def step_impl(context: Context):
    context.submarine = Submarine()


@when('submarine receives command {command}')
def submarine_receives_command(context: Context, command):
    context.submarine.execute_command(command)


@then('submarine depth should be {value:d}')
def submarine_depth_should_be(context: Context, value: int):
    assert context.submarine.depth() == value


@then('submarine position should be {value:d}')
def submarine_position_should_be(context: Context, value: int):
    assert context.submarine.position() == value


@then('submarine aim should be {value:d}')
def submarine_aim_should_be(context: Context, value: int):
    assert context.submarine.aim() == value


@then('submarine final value should be {value:d}')
def submarine_depth_should_be(context: Context, value: str):
    assert context.submarine.position() * context.submarine.depth() == value
