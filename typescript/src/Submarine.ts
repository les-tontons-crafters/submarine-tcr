import {SubmarineInterface} from "@submarine-domain/SubmarineInterface";

export class Submarine implements SubmarineInterface
{
    public executeCommand = (command: string) => {
        throw new Error('Not implemented')
    };
    public aim = (): number => {
        throw new Error('Not implemented')
    };
    public position = (): number => {
        throw new Error('Not implemented')
    };
    public depth = (): number => {
        throw new Error('Not implemented')
    };
}
