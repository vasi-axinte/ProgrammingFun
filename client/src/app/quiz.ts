import { Question } from './question';

export interface Quiz {
    quizName: string,
    questions: Question[]
}