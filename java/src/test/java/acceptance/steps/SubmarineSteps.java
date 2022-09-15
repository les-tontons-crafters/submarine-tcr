package acceptance.steps;

import domain.Submarine;
import io.cucumber.java.en.And;
import io.cucumber.java.en.Then;
import io.cucumber.java.en.When;

import static acceptance.Utils.FileUtils.getInputAsSeparatedLines;
import static java.util.Arrays.stream;
import static org.assertj.core.api.Assertions.assertThat;

public class SubmarineSteps {
    private final Submarine submarine;

    public SubmarineSteps() {
        submarine = new Submarine();
    }

    private static int calculateFinalValue(Submarine submarine) {
        return submarine.getPosition() * submarine.getDepth();
    }

    @When("^submarine receives command (.*)")
    public void receivesCommand(String command) {
        submarine.executeCommand(command);
    }

    @When("^submarine receives all commands from file (.*)$")
    public void receivesAllCommandsFromResourceFile(String fileName) {
        stream(getInputAsSeparatedLines(fileName))
                .forEach(submarine::executeCommand);
    }
    
    @Then("^submarine depth should be (\\d+)$")
    public void depthShouldBe(int expectedDepth) {
        assertThat(submarine.getDepth())
                .isEqualTo(expectedDepth);
    }

    @And("^submarine position should be (\\d+)$")
    public void positionShouldBe(int expectedPosition) {
        assertThat(submarine.getPosition())
                .isEqualTo(expectedPosition);
    }

    @And("^submarine aim should be (\\d+)$")
    public void aimShouldBe(int expectedAim) {
        assertThat(submarine.getAim())
                .isEqualTo(expectedAim);
    }

    @And("^submarine final value should be (\\d+)$")
    public void finalValueShouldBe(int expectedFinalValue) {
        assertThat(calculateFinalValue(submarine))
                .isEqualTo(expectedFinalValue);
    }
}
