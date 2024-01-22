export interface GameTimes {
    percentualGreenColumns: number
    idCompetion: number
    descricao: any
    mercado: any
    lines: Line[]
    minutes: Minute[]
    resultadoSequencia: any[]
}

export interface Line {
    columnsIsGreen: boolean
    hora: number
    cells: Cell[]
    percents: number
    percentsSelectedMinutes: number
}

export interface Cell {
    borderColor: any
    minute: number
    countable: boolean
    result?: string
    isGreen: boolean
    tooltip?: string
    sumScore: number
}

export interface Minute {
    number: number
    countGreen: number
    percents: number
}