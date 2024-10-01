module.exports = {
  roots: ["<rootDir>/tests"],
  collectCoverageFrom: ["<rootDir>/src/**/*.ts"],
  coverageDirectory: "coverage",
  coverageProvider: "v8",
  testEnvironment: "node",
  transform: {
    ".+\\.ts$": "ts-jest",
  },
  testMatch: [
    "**/*.steps.ts",
    "**/*.spec.ts"
  ],
  moduleNameMapper: {
    "@submarine-domain/(.*)": "<rootDir>/src/$1",
  },
  setupFilesAfterEnv: ["jest-extended/all", "jest-chain"],
};
