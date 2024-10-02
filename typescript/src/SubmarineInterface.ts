export interface SubmarineInterface {
    executeCommand(command: string): void;

    aim(): number;

    position(): number;

    depth(): number;
}