declare module '@wulkanowy/qr-node' {
  export function encode(password: string, content: string): string;
  export function decode(password: string, content: string): string;
}
