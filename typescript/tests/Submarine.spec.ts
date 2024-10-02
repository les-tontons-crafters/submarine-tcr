import {Submarine} from "@submarine-domain/Submarine";


describe("Submarine", () => {
  const submarine = new Submarine()
  test("fake", () => {
    expect(submarine).not.toBeNull()
  });
});
