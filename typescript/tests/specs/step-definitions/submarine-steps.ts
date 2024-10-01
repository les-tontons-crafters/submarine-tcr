import {StepDefinitions} from "jest-cucumber";
import {Submarine} from "@submarine-domain/Submarine";


export const subamrineSteps: StepDefinitions = ({given, and, when, then}) => {
    let submarine = new Submarine()

    when(/submarine receives command (.*)$/, (command: string) => {
        submarine.executeCommand(command)
    })

    then(/^submarine depth should be (\d+)$/, (position: string) => {
        expect(submarine.depth()).toBe(parseInt(position))
    });

    then(/^submarine position should be (\d+)$/, (position: string) => {
        expect(submarine.position()).toBe(parseInt(position))
    });

    then(/^submarine aim should be (\d+)$/, (position: string) => {
        expect(submarine.aim()).toBe(parseInt(position))
    });

    then(/^submarine final value should be (\d+)$/, (position: string) => {
        expect(submarine.aim()).toBe(parseInt(position))
    });
}