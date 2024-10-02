from src.submarine import Submarine


class TestSubmarine():
    def test_with_a_fake_test(self):
        submarine = Submarine()
        assert submarine is not None
