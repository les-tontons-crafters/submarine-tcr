package unit;

import domain.Submarine;
import org.junit.jupiter.api.BeforeEach;
import org.junit.jupiter.api.Test;

import static org.assertj.core.api.Assertions.assertThat;

class SubmarineTests {
    private Submarine submarine;

    @BeforeEach
    void setup() {
        submarine = new Submarine();
    }

    @Test
    void fakeTest() {
        assertThat(submarine)
                .isNotNull();
    }
}